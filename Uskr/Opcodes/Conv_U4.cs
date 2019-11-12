using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Uskr.Attributes;
using Uskr.Core;
using Uskr.IR;

namespace Uskr.Opcodes
{
    [Handler(Code.Conv_U4)]
    public class Conv_U4 : IOpcodeProcessor
    {
        public void Handel(IRAssembly assembly, IRMethod meth, UskrContext context, Instruction instruction)
        {
                             //       Logger.Debug($"Not Implemented: {instruction.OpCode.Code}");

        }
    }
}