using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.Core.Syntax
{
    public class JSKeyword : JSToken
    {
        public JSKeyword(Keyword keyword)
        {
            _KeywordEnum = keyword;
        }
        
        public Keyword KeywordEnum
        {
            get
            {
                return _KeywordEnum;
            }
        }
        private Keyword _KeywordEnum;

    }



    #region Region: Language Enums
    #region Region: Reserved Words (Ecma-262.pdf p18-p19)
    public enum Keyword
    {
        BREAK,
        DO,
        INSTANCEOF,
        TYPEOF,
        CASE,
        ELSE,
        NEW,
        VAR,
        CATCH,
        FINALLY,
        RETURN,
        VOID,
        CONTINUE,
        FOR,
        SWITCH,
        WHILE,
        DEBUGGER,
        FUNCTION,
        THIS,
        WITH,
        DEFAULT,
        IF,
        THROW,
        DELETE,
        IN,
        TRY
    }
    public enum FutureReservedWord
    {
        CLASS,
        ENUM,
        EXTENDS,
        SUPER,
        CONST,
        EXPORT,
        IMPORT,
        IMPLEMENTS,
        LET,
        PRIVATE,
        PUBLIC,
        YIELD,
        INTERFACE,
        PACKAGE,
        PROTECTED,
        STATIC
    }
    #endregion
    #endregion
}
