using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Uskr.Attributes;
using Uskr.Core;
using Uskr.IR;

namespace Uskr.Opcodes
{
    [Handler(Code.Ldind_R4)]
    public class Ldind_R4 : IOpcodeProcessor
    {
        public void Handel(IRAssembly assembly, IRMethod meth, UskrContext context, Instruction instruction)
        {
                                    context.Asm($"pop eax");
                        context.Asm($"mov ebx, [eax]");
                        context.Asm($"push ebx");

        }
    }
}