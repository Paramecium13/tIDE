﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using xTile;
using xTile.Format;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace tIDE.Format
{
    internal class MappyFmapFormat: IMapFormat
    {
        #region Public Methods

        public CompatibilityReport DetermineCompatibility(xTile.Map map)
        {
            throw new NotImplementedException();
        }

        public Map Load(Stream stream)
        {
            ReadHeader(stream);

            MphdRecord mphdRecord = null;
            Color[] colourMap = null;
            BlockRecord[] blockRecords = null;
            AnimationRecord[] animationRecords = null;
            Image imageSource = null;
            short[][] layers = new short[8][];

            Map map = new Map();

            foreach (Chunk chunk in MapChunks(stream))
            {
                //MessageBox.Show("Chunk ID = " + chunk.Id + ", Len = " + chunk.Data.Length);

                if (chunk.Id == "ATHR")
                    ReadChunkATHR(stream, chunk, map);
                else if (chunk.Id == "MPHD")
                    mphdRecord = ReadChunkMPHD(stream, chunk);
                else if (chunk.Id == "CMAP")
                    colourMap = ReadChunkCMAP(stream, chunk);
                else if (chunk.Id == "BKDT")
                    blockRecords = ReadChunkBKDT(stream, chunk, mphdRecord);
                else if (chunk.Id == "ANDT")
                    animationRecords = ReadChunkANDT(stream, chunk, mphdRecord);
                else if (chunk.Id == "BGFX")
                    imageSource = ReadChuckBGFX(stream, chunk, mphdRecord, colourMap);
                else if (chunk.Id == "BODY")
                    layers[0] = ReadChunkLayer(stream, chunk, mphdRecord);
                else if (chunk.Id.Length == 4 && chunk.Id.StartsWith("LYR"))
                {
                    char chLast = chunk.Id[3];
                    if (chLast >= '1' && chLast <= '7')
                        layers[chLast - '0'] = ReadChunkLayer(stream, chunk, mphdRecord);
                }
            }

            return map;
        }

        public void Store(Map map, Stream stream)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Public Properties

        public string Name
        {
            get { return "Mappy FMP Format"; }
        }

        public string FileExtensionDescriptor
        {
            get { return "Mappy FMP Files (*.fmp)"; }
        }

        public string FileExtension
        {
            get { return "fmp"; }
        }

        #endregion

        #region Private Methods

        private byte ReadUnsignedByte(Stream stream)
        {
            int byt = stream.ReadByte();
            if (byt < 0)
                throw new Exception("Unexpected end of file while reading unsigned byte");
            return (byte)byt;
        }

        private sbyte ReadSignedByte(Stream stream)
        {
            int byt = stream.ReadByte();
            if (byt < 0)
                throw new Exception("Unexpected end of file while reading signed byte");
            return (sbyte)byt;
        }

        private short ReadShortMsb(Stream stream)
        {
            byte[] shortBytes = new byte[2];

            long position = stream.Position;
            if (stream.Read(shortBytes, 0, 2) != 2)
                throw new Exception("Error reading MSB short int at position " + position);

            short value = (short)((shortBytes[0] << 8) | shortBytes[1]);

            return value;
        }

        private short ReadShortLsb(Stream stream)
        {
            byte[] shortBytes = new byte[2];

            long position = stream.Position;
            if (stream.Read(shortBytes, 0, 2) != 2)
                throw new Exception("Error reading MSB short int at position " + position);

            short value = (short)((shortBytes[1] << 8) | shortBytes[0]);

            return value;
        }

        private short ReadShort(Stream stream, bool lsb)
        {
            return lsb ? ReadShortLsb(stream) : ReadShortMsb(stream);
        }

        private ushort ReadUnsignedShortMsb(Stream stream)
        {
            byte[] shortBytes = new byte[2];

            long position = stream.Position;
            if (stream.Read(shortBytes, 0, 2) != 2)
                throw new Exception("Error reading MSB short int at position " + position);

            ushort value = (ushort)((shortBytes[0] << 8) | shortBytes[1]);

            return value;
        }

        private ushort ReadUnsignedShortLsb(Stream stream)
        {
            byte[] shortBytes = new byte[2];

            long position = stream.Position;
            if (stream.Read(shortBytes, 0, 2) != 2)
                throw new Exception("Error reading MSB short int at position " + position);

            ushort value = (ushort)((shortBytes[1] << 8) | shortBytes[0]);

            return value;
        }

        private ushort ReadUnsignedShort(Stream stream, bool lsb)
        {
            return lsb ? ReadUnsignedShortLsb(stream) : ReadUnsignedShortMsb(stream);
        }

        private ulong ReadUnsignedLongMsb(Stream stream)
        {
            byte[] longBytes = new byte[4];

            long position = stream.Position;
            if (stream.Read(longBytes, 0, 4) != 4)
                throw new Exception("Error reading MSB long at position " + position);

            ulong value = (ulong)((longBytes[0] << 24) | (longBytes[1] << 16)
                | (longBytes[2] << 8) | longBytes[3]);

            return value;
        }

        private ulong ReadUnsignedLongLsb(Stream stream)
        {
            byte[] longBytes = new byte[4];

            long position = stream.Position;
            if (stream.Read(longBytes, 0, 4) != 4)
                throw new Exception("Error reading LSB long at position " + position);

            ulong value = (ulong)((longBytes[3] << 24) | (longBytes[2] << 16)
                | (longBytes[1] << 8) | longBytes[0]);

            return value;
        }

        private ulong ReadUnsignedLong(Stream stream, bool lsb)
        {
            return lsb ? ReadUnsignedLongLsb(stream) : ReadUnsignedLongMsb(stream);
        }

        private long ReadSignedLongMsb(Stream stream)
        {
            byte[] longBytes = new byte[4];

            long position = stream.Position;
            if (stream.Read(longBytes, 0, 4) != 4)
                throw new Exception("Error reading MSB long at position " + position);

            long value = (longBytes[0] << 24) | (longBytes[1] << 16)
                | (longBytes[2] << 8) | longBytes[3];

            return value;
        }

        private long ReadSignedLongLsb(Stream stream)
        {
            byte[] longBytes = new byte[4];

            long position = stream.Position;
            if (stream.Read(longBytes, 0, 4) != 4)
                throw new Exception("Error reading LSB long at position " + position);

            long value = (longBytes[3] << 24) | (longBytes[2] << 16)
                | (longBytes[1] << 8) | longBytes[0];

            return value;
        }

        private long ReadSignedLong(Stream stream, bool lsb)
        {
            return lsb ? ReadSignedLongLsb(stream) : ReadSignedLongMsb(stream);
        }

        private string ReadSequence(Stream stream, int count)
        {
            try
            {
                byte[] byteSequence = new byte[count];

                long position = stream.Position;
                if (stream.Read(byteSequence, 0, count) != count)
                    throw new Exception("Unexpected end of file while reading sequence of " + count + " bytes at position " + position);

                return ASCIIEncoding.ASCII.GetString(byteSequence);
            }
            catch (Exception exception)
            {
                throw new Exception("Error while reading char sequence of lengh " + count, exception);
            }
        }

        private void ReadSequence(Stream stream, string sequence)
        {
            try
            {
                long position = stream.Position;
                string readSequence = ReadSequence(stream, sequence.Length);

                if (readSequence != sequence)
                    throw new Exception("Expected sequence '" + sequence + "' at position " + position);
            }
            catch (Exception exception)
            {
                throw new Exception("Error wile matching char sequence '" + sequence + "'", exception);
            }
        }

        private void ReadHeader(Stream stream)
        {
            ReadSequence(stream, "FORM");
            long storedLength = ReadSignedLongMsb(stream);
            long actualLength = stream.Length - 8;
            if (storedLength != actualLength)
                throw new Exception(
                    "Mappy Header: File body length mismatch: stored = " + storedLength + ", actual = " + actualLength);
            ReadSequence(stream, "FMAP");
        }

        private Chunk MapChunk(Stream stream)
        {
            string chunkId = ReadSequence(stream, 4);
            long chunkLength = ReadSignedLongMsb(stream);
            if (chunkLength > int.MaxValue)
                throw new Exception("Chunk sizes greater than " + int.MaxValue + " not supported");
            if (stream.Position + chunkLength > stream.Length)
                throw new Exception("Lenght of chunk '" + chunkId + "' exceeds end of file");

            Chunk chunk = new Chunk();
            chunk.Id = chunkId;
            chunk.FilePosition = stream.Position;
            chunk.Length = (int) chunkLength;

            stream.Position += chunkLength;

            return chunk;
        }

        private IEnumerable<Chunk> MapChunks(Stream stream)
        {
            List<Chunk> chunks = new List<Chunk>();
            while (stream.Position < stream.Length)
            {
                Chunk chunk = MapChunk(stream);
                chunks.Add(chunk);
            }
            return chunks;
        }

        private void ReadChunkATHR(Stream stream, Chunk chunk, Map map)
        {
            stream.Position = chunk.FilePosition;
            byte[] chunkData = new byte[chunk.Length];
            stream.Read(chunkData, 0, chunk.Length);
            string authors = ASCIIEncoding.ASCII.GetString(chunkData);
            string[] authorLines = authors.Split(new char[] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string authorLine in authorLines)
                stringBuilder.AppendLine(authorLine);
            map.Description = stringBuilder.ToString();
        }

        private MphdRecord ReadChunkMPHD(Stream stream, Chunk chunk)
        {
            MphdRecord mphdRecord = new MphdRecord();

            stream.Position = chunk.FilePosition;
            mphdRecord.VersionHigh = ReadSignedByte(stream);
            mphdRecord.VersionLow = ReadSignedByte(stream);
            mphdRecord.LSB = ReadSignedByte(stream) != 0;
            mphdRecord.MapType = ReadSignedByte(stream);

            if (mphdRecord.MapType != 0)
                throw new Exception("Only MapType = 0 is supported");

            mphdRecord.MapWidth = ReadShort(stream, mphdRecord.LSB);
            mphdRecord.MapHeight = ReadShort(stream, mphdRecord.LSB);
            mphdRecord.Reserved1 = ReadShort(stream, mphdRecord.LSB);
            mphdRecord.Reserved2 = ReadShort(stream, mphdRecord.LSB);
            mphdRecord.BlockWidth = ReadShort(stream, mphdRecord.LSB);
            mphdRecord.BlockHeight = ReadShort(stream, mphdRecord.LSB);
            mphdRecord.BlockDepth = ReadShort(stream, mphdRecord.LSB);
            mphdRecord.BlockStructSize = ReadShort(stream, mphdRecord.LSB);
            mphdRecord.NumBlockStruct = ReadShort(stream, mphdRecord.LSB);
            mphdRecord.NumBlockGfx = ReadShort(stream, mphdRecord.LSB);

            if (chunk.Length > 24)
            {
                mphdRecord.ColourKeyIndex = ReadUnsignedByte(stream);
                mphdRecord.ColourKeyRed = ReadUnsignedByte(stream);
                mphdRecord.ColourKeyGreen = ReadUnsignedByte(stream);
                mphdRecord.ColourKeyBlue = ReadUnsignedByte(stream);

                if (chunk.Length > 28)
                {
                    mphdRecord.BlockGapX = ReadShort(stream, mphdRecord.LSB);
                    mphdRecord.BlockGapY = ReadShort(stream, mphdRecord.LSB);
                    mphdRecord.BlockStaggerX = ReadShort(stream, mphdRecord.LSB);
                    mphdRecord.BlockStaggerY = ReadShort(stream, mphdRecord.LSB);

                    if (chunk.Length > 36)
                    {
                        mphdRecord.ClickMask = ReadShort(stream, mphdRecord.LSB);
                        mphdRecord.Pillars = ReadShort(stream, mphdRecord.LSB);
                    }
                }
            }

            return mphdRecord;
        }

        private Color[] ReadChunkCMAP(Stream stream, Chunk chunk)
        {
            stream.Position = chunk.FilePosition;
            int colourCount = chunk.Length / 3;
            Color[] colourMap = new Color[colourCount];
            for (int index = 0; index < colourCount; index++)
            {
                byte red = ReadUnsignedByte(stream);
                byte green = ReadUnsignedByte(stream);
                byte blue = ReadUnsignedByte(stream);
                Color colour = Color.FromArgb(red, green, blue);
                colourMap[index] = colour;
            }

            return colourMap;
        }

        private BlockRecord[] ReadChunkBKDT(Stream stream, Chunk chunk, MphdRecord mphdRecord)
        {
            BlockRecord[] blockRecords = new BlockRecord[mphdRecord.NumBlockStruct];
            bool lsb = mphdRecord.LSB;
            for(int index = 0; index < mphdRecord.NumBlockStruct; index++)
            {
                stream.Position = chunk.FilePosition + mphdRecord.BlockStructSize * index;

                BlockRecord blockRecord = new BlockRecord();
                blockRecord.BackgroundOffset = ReadSignedLong(stream, lsb);
                blockRecord.ForegroundOffset = ReadSignedLong(stream, lsb);
                blockRecord.BackgroundOffset2 = ReadSignedLong(stream, lsb);
                blockRecord.ForegroundOffset2 = ReadSignedLong(stream, lsb);
                blockRecord.User1 = ReadUnsignedLong(stream, lsb);
                blockRecord.User2 = ReadUnsignedLong(stream, lsb);
                blockRecord.User3 = ReadUnsignedShort(stream, lsb);
                blockRecord.User4 = ReadUnsignedShort(stream, lsb);
                blockRecord.User5 = ReadUnsignedByte(stream);
                blockRecord.User6 = ReadUnsignedByte(stream);
                blockRecord.User7 = ReadUnsignedByte(stream);
                blockRecord.Flags = ReadUnsignedByte(stream);
                blockRecords[index] = blockRecord;
            }

            return blockRecords;
        }

        private AnimationRecord[] ReadChunkANDT(Stream stream, Chunk chunk, MphdRecord mphdRecord)
        {
            List<AnimationRecord> animationRecords = new List<AnimationRecord>();
            bool lsb = mphdRecord.LSB;
            stream.Position = chunk.FilePosition;
            while (true)
            {
                AnimationRecord animationRecord = new AnimationRecord();
                animationRecord.Type = ReadSignedByte(stream);
                animationRecord.Delay = ReadSignedByte(stream);
                animationRecord.Counter = ReadSignedByte(stream);
                animationRecord.UserInfo = ReadSignedByte(stream);
                animationRecord.CurrentOffset = ReadSignedLong(stream, lsb);
                animationRecord.StartOffset = ReadSignedLong(stream, lsb);
                animationRecord.EndOffset = ReadSignedLong(stream, lsb);

                animationRecords.Add(animationRecord);
                if (animationRecord.Type < 0)
                    break;
            }

            return animationRecords.ToArray();
        }

        private Image ReadChuckBGFX(Stream stream, Chunk chunk, MphdRecord mphdRecord, Color[] colourMap)
        {
            byte[] imageData = new byte[chunk.Length];
            stream.Read(imageData, 0, chunk.Length);

            int tileCount = mphdRecord.NumBlockStruct;
            int imageWidth = mphdRecord.BlockWidth;
            int imageHeight = mphdRecord.BlockHeight * tileCount;
            PixelFormat pixelFormat = PixelFormat.Undefined;
            if (mphdRecord.BlockDepth == 8)
                pixelFormat = PixelFormat.Format8bppIndexed;
            else if (mphdRecord.BlockDepth == 16)
                pixelFormat = PixelFormat.Format16bppRgb565;
            else if (mphdRecord.BlockDepth == 24)
                pixelFormat = PixelFormat.Format24bppRgb;
            else if (mphdRecord.BlockDepth == 32)
                pixelFormat = PixelFormat.Format32bppArgb;
            else if (mphdRecord.BlockDepth == 64)
                pixelFormat = PixelFormat.Format64bppArgb;
            
            Bitmap imageSource = new Bitmap(imageWidth, imageHeight, pixelFormat);
            if (mphdRecord.BlockDepth == 8)
            {
                // set palette
                if (colourMap != null)
                    for (int index = 0; index < colourMap.Length; index++)
                        imageSource.Palette.Entries[index] = colourMap[index];

                // de-interleave bit planes
                /*
                byte[] indexData = new byte[chunk.Length];
                int planeOffset = chunk.Length / 8;
                for (int index = 0; index < chunk.Length; index++)
                {
                    indexData[index] = 0;
                    for (int plane = 0; plane < 8; plane++)
                        indexData[index] |= (byte)(((imageData[plane * planeOffset + index / 8] >> plane) & 1)<< (7 - plane));
                }
                imageData = indexData;
                */
            }

            BitmapData bitmapData = imageSource.LockBits(new Rectangle(Point.Empty, imageSource.Size), ImageLockMode.WriteOnly, pixelFormat);
            Marshal.Copy(imageData, 8, bitmapData.Scan0, imageData.Length - 8);
            imageSource.UnlockBits(bitmapData);

            for (int y = 0; y < imageSource.Height; y++)
            {
                for (int x = 0; x < imageSource.Width; x++)
                {
                    Color c = imageSource.GetPixel(x, y);
                    c = Color.FromArgb(c.B, c.G, c.R);
                    imageSource.SetPixel(x, y, c);
                }
            }

            //imageSource.Save("C:\\test.gif", ImageFormat.Gif);
            imageSource.Save("C:\\test.png", ImageFormat.Png);

            return imageSource;
        }


        private short[] ReadChunkLayer(Stream stream, Chunk chunk, MphdRecord mphdRecord)
        {
            bool lsb = mphdRecord.LSB;
            short[] offsets = new short[chunk.Length / 2];
            for (int index = 0; index < offsets.Length; index++)
            {
                short offset = ReadShort(stream, lsb);
                if (mphdRecord.VersionHigh > 0)
                {
                    if (offset < 1)
                        offset /= mphdRecord.BlockStructSize;
                    else
                        offset /= AnimationRecord.SIZE;
                }
                offsets[index] = offset;
            }
            return offsets;
        }

        #endregion

        #region Private Classes

        private struct Chunk
        {
            internal string Id;
            internal long FilePosition;
            internal int Length;
        }

        private class MphdRecord
        {
            internal sbyte VersionHigh;
            internal sbyte VersionLow;
            internal bool LSB;
            internal sbyte MapType;
            internal short MapWidth;
            internal short MapHeight;
            internal short Reserved1;
            internal short Reserved2;
            internal short BlockWidth;
            internal short BlockHeight;
            internal short BlockDepth;
            internal short BlockStructSize;
            internal short NumBlockStruct;
            internal short NumBlockGfx;
            internal byte ColourKeyIndex;
            internal byte ColourKeyRed;
            internal byte ColourKeyGreen;
            internal byte ColourKeyBlue;
            internal short BlockGapX;
            internal short BlockGapY;
            internal short BlockStaggerX;
            internal short BlockStaggerY;
            internal short ClickMask;
            internal short Pillars;
        }

        private class BlockRecord
        {
            internal long BackgroundOffset, ForegroundOffset;
            internal long BackgroundOffset2, ForegroundOffset2;
            internal ulong User1, User2;
            internal ushort User3, User4;
            internal byte User5, User6, User7;
            internal byte Flags;
        }

        private class AnimationRecord
        {
            internal const int SIZE = 16;
            internal sbyte Type;
            internal sbyte Delay;
            internal sbyte Counter;
            internal sbyte UserInfo;
            internal long  CurrentOffset;
            internal long  StartOffset;
            internal long  EndOffset;
        }

        #endregion
    }
}
