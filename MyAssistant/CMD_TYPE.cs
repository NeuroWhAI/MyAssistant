using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MyAssistant
{
    public class StringValue : System.Attribute
    {
        public StringValue(string Value)
        {
            m_Str = Value;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        private string m_Str;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        public string GetStr()
        {
            return m_Str;
        }
    }


    public static class StringEnum
    {
        public static string GetStringValue(CMD_TYPE Val)
        {
            string Result = null;

            Type type = Val.GetType();

            FieldInfo fi = type.GetField(Val.ToString());
            StringValue[] attrs = fi.GetCustomAttributes(typeof(StringValue), false) as StringValue[];

            if (attrs.Length > 0)
            {
                Result = attrs[0].GetStr();
            }


            return Result;
        }
    }


    public enum CMD_TYPE
    {
        [StringValue("")]
        None,

        [StringValue("음성인식 작동")]
        Run_Assistant,

        [StringValue("음성인식 정지")]
        Stop_Assistant,

        [StringValue("프로그램 실행")]
        Run_Program,

        [StringValue("프로그램 종료")]
        Exit_Program,

        [StringValue("최상위 창 종료")]
        Exit_Top_Program,

        [StringValue("최상위 창 최소화")]
        Mini_Top_Program,

        [StringValue("내렸던 창 최대화")]
        Max_PrevMini_Program,

        [StringValue("최상위 창 숨기기")]
        Hide_Top_Program,

        [StringValue("숨겼던 창 모두 열기")]
        Show_All_Hide_Program,

        [StringValue("말하기")]
        Say_Sentence,

        [StringValue("키보드 입력")]
        Keyboard_Input,

        [StringValue("타이핑")]
        Typing_Str,
    }
}
