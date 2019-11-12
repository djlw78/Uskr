using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Uskr.Attributes;
using Uskr.Core;
using Uskr.IR;

namespace Uskr.Opcodes
{
    [Handler(Code.Div_Un)]
    public class Div_Un : IOpcodeProcessor
    {
        public void Handel(IRAssembly assembly, IRMethod meth, UskrContext context, Instruction instruction)
        {
                                    context.Asm("mov edx, 0");
                        context.Asm("pop eax");
                        context.Asm("pop ecx");
                        context.Asm("div ecx");
                        context.Asm("push eax");

        }
    }
}