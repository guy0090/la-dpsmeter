/*
 * This file has been Auto Generated, Please do not edit.
 * If you need changes, follow the instructions written in the readme.md
 *
 * Generated by Herysia.
 */

using System;
using System.Collections.Generic;
using LostArkLogger.Types;

namespace LostArkLogger
{
    public class Struct_637
    {
        public bool valid = false;
        internal Struct_637()
        {
            //Made for conditional structures
        }

        internal Struct_637(BitReader reader)
        {
            valid = true;
            struct_429 = new Struct_429(reader);
            Unk1 = reader.ReadInt16();
            Unk2 = reader.ReadInt16();
            Unk3 = reader.ReadByte();
            if(Unk3 == 1)
            {
                Unk3_0 = reader.ReadByte();
            }
            Unk4 = reader.ReadInt32();
            lostArkDateTime = new LostArkDateTime(reader);
        }

        public Struct_429 struct_429 { get; } = new Struct_429();
        public short Unk1 { get; }
        public short Unk2 { get; }
        public byte Unk3 { get; }
        public byte Unk3_0 { get; }
        public int Unk4 { get; }
        public LostArkDateTime lostArkDateTime { get; } = new LostArkDateTime();
    }
}