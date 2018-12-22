using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatBuffer
{
    public partial class Procedure : IProcedure
    {
        public bool Procedure_CompileCode()
        {
            bool compileResult = CompileHelper.CompileCSharpCode();
            string strResult = compileResult ? "成功" : "失败";
            Debug.Log("编译CSharp结果:" + strResult);
            if (compileResult)
            {
                AddDelayRun(() => {
                    Procedure_GenerateBytes();
                });
            }
            return true;
        }


    }
}
