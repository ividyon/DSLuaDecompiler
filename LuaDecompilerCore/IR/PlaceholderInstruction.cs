﻿namespace LuaDecompilerCore.IR
{
    /// <summary>
    /// Simple string based placeholder until IR is implemented
    /// </summary>
    class PlaceholderInstruction : IInstruction
    {
        public string Placeholder;
        
        public PlaceholderInstruction(string place)
        {
            Placeholder = place;
        }

        public override string ToString()
        {
            return Placeholder;
        }
    }
}
