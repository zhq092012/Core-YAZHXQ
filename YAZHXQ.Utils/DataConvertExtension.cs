using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace YAZHXQ.Utils
{
    public static class DataConvertExtension
    {
        #region +++++数据类型转换

        /// <summary>
        /// 将一个字符串转换为整型，转换失败时返回0
        /// </summary>
        /// <param name="str">待转换的字符转</param>
        /// <returns>整数</returns>

        public static int ToInt(this string str)
        {
            int result;
            int.TryParse(str, out result);
            return result;
        }

        public static int ToInt(object obj)
        {
            if (obj == null)
                return 0;
            return ToInt(obj.ToString());
        }

        public static string ToString(object obj)
        {
            if (obj == null)
                return "";
            return obj.ToString();
        }

        /// <summary>
        /// 将一个字符串转换为decimal，转换失败时返回0
        /// </summary>
        /// <param name="str">待转换的字符转</param>
        /// <returns>decimal型</returns>
        public static decimal ToDecimal(string str)
        {
            decimal result;
            decimal.TryParse(str, out result);
            return result;
        }
        /// <summary>
        /// 将一个字符串转换为double，转换失败时返回0
        /// </summary>
        /// <param name="str">待转换的字符转</param>
        /// <returns>double型</returns>
        public static double DoDouble(string str)
        {
            double result;
            double.TryParse(str, out result);
            return result;
        }
        #endregion

        #region +++++字符串替换、截取、拼接操作

        /// <summary>
        /// 截取指定长度的字符串
        /// </summary>
        /// <param name="str">要截取的字符串</param>
        /// <param name="length">截取长度</param>
        /// <returns></returns>
        public static string TrimTo(this string str, int length)
        {
            //如果为null或空字符串，则返回string.Empty
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            if (str.Length <= length)
                return str;
            return str.SubStr(0, length, false);
        }

        /// <summary>
        /// 获取指定长度的子字符串
        /// 杨涛 2016-5-12
        /// </summary>
        /// <param name="str"></param>
        /// <param name="startIndex">起始索引</param>
        /// <param name="length">子字符串长度</param>
        /// <param name="addEllipsis">截取后是否添加省略号</param>
        /// <returns></returns>
        public static string SubStr(this string str, int startIndex, int length, bool addEllipsis = false)
        {
            //如果为null或空字符串，则返回string.Empty
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            //如果字符串长度小于起始索引，则返回string.Empty;
            if (str.Length < startIndex)
            {
                return string.Empty;
            }
            //如果起始索引小于0，则设为0
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            //如果字符串长度小于或等于起始索引+要截取的长度，则返回从起始索引开始之后的字符串
            if (str.Length <= startIndex + length)
            {
                return str.Substring(startIndex, str.Length - startIndex);
            }
            //否则返回从指定索引开始的指定长度的子字符串，并根据addEllipsis参数值决定是否添加省略号
            return str.Substring(startIndex, length) + (addEllipsis ? "…" : "");
        }

        /// <summary>
        /// 获取指定长度的子字符串
        /// 杨涛 2016-5-12
        /// </summary>
        /// <param name="str"></param>
        /// <param name="startIndex">起始索引</param>
        /// <returns></returns>
        public static string SubStr(this string str, int startIndex)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            return str.SubStr(startIndex, str.Length - startIndex);
        }

        /// <summary>
        /// 取得汉字字符串，如过长时加...
        /// </summary>
        /// <param name="strVal">汉字字符串</param>
        /// <param name="intMaxLength">长度</param>
        /// <returns>取得长度的汉字字符串</returns>
        public static string GB2312Left(string strVal, int intMaxLength)
        {
            if (!string.IsNullOrEmpty(strVal))
            {
                if (strVal.Length > intMaxLength)
                {
                    return GB2312SubString(strVal, intMaxLength) + "...";
                }
            }
            return strVal;
        }

        /// <summary>
        /// 汉字字符串截取
        /// </summary>
        /// <param name="strVal">汉字字符串</param>
        /// <param name="intMaxLength">长度</param>
        /// <returns>取得长度的汉字字符串</returns>
        public static string GB2312SubString(string strVal, int intMaxLength)
        {
            if (string.IsNullOrEmpty(strVal))
                return string.Empty;
            int strLength = 0;
            int charNum = 0;
            for (int i = 0; i < strVal.Length; i++)
            {
                byte[] Byte = Encoding.GetEncoding("gb2312").GetBytes(strVal[i].ToString());
                charNum += 1;
                strLength += Byte.Length;
                if (strLength > intMaxLength * 2) break;
            }
            if (strLength > intMaxLength * 2)
            {
                return strVal.Substring(0, charNum - 1);
            }
            return strVal;
        }

        public static string CreateRandomCode(int length)
        {
            string strChar = "123456789abcdefghijklmnpqrstuvwxyzABCDEFGHIJKLMNPQRSTUVWXYZ";
            string strRandom = string.Empty;
            Random Rnd = new Random();
            //生成随机字符串
            for (int i = 0; i < length; i++)
            {
                strRandom += strChar[Rnd.Next(strChar.Length)];
            }
            return strRandom;
        }
        #endregion


        #region  +++++页面提交内容过滤转换

        /// <summary>
        /// 从字符串中删除html标记内容.
        /// 杨涛 2015-11-17
        /// </summary>
        public static string RemoveHtmlTags(string source)
        {
            if (string.IsNullOrWhiteSpace(source))
                return string.Empty;
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }

        #endregion

        /// <summary>
        /// 将html内容中src和href指向的相对路径替换为带域名的绝对路径url
        /// </summary>
        /// <param name="htmlContent">原始html文本内容</param>
        /// <param name="domain">域名</param>
        /// <returns></returns>
        public static string ConvertRelativeUrlToAbsolute(string htmlContent, string domain)
        {
            var baseUri = new Uri(domain);
            var pattern = "(?<name>src|href)=(\'|\")(?<value>[^(\'|\")]*)(\'|\")";
            var matchEvaluator = new MatchEvaluator(
                match =>
                {
                    var value = match.Groups["value"].Value;
                    if (Uri.TryCreate(baseUri, value, out var uri))
                    {
                        var name = match.Groups["name"].Value;
                        return $"{name}=\"{uri.AbsoluteUri}\"";
                    }
                    return null;
                });
            return Regex.Replace(htmlContent, pattern, matchEvaluator);

            #region HtmlAglitypack实现方法，因HtmlAgilityPack有去除自动关闭标签的bug且会改动原始html内容而放弃
            /* 
            var htmlDoc = new HtmlDocument{OptionWriteEmptyNodes = true};
            HtmlNode.ElementsFlags.Remove("meta");
            htmlDoc.LoadHtml(htmlContent);
            var nodes = htmlDoc.DocumentNode.SelectNodes("//*[@href or @src or @action]");
            foreach (HtmlNode node in nodes)
            {
                string attrName;
                switch (node.Name.ToLower())
                {
                    case "a":
                    case "link":
                        attrName = "href";
                        break;
                    case "form":
                        attrName = "action";
                        break;
                    default:
                        attrName = "src";
                        break;
                }
                var path = node.GetAttributeValue(attrName, string.Empty);
                var uri=new Uri(path,UriKind.RelativeOrAbsolute);
                if (!uri.IsAbsoluteUri)
                {
                    uri=new Uri(baseUri,path);
                }
                node.SetAttributeValue(attrName,uri.AbsoluteUri);
            }
            StringWriter writer = new StringWriter();
            htmlDoc.Save(writer);
            return writer.ToString();*/
            #endregion
        }


        /// <summary>
        /// 移除特殊字符
        /// </summary>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public static string RemoveCode(string str)
        {
            return string.IsNullOrWhiteSpace(str) ? "" :
                str.Replace("+", "")
                    .Replace(" ", "")
                    .Replace("/", "")
                    .Replace("?", "")
                    .Replace("%", "")
                    .Replace("#", "")
                    .Replace("&", "")
                    .Replace("=", "");
        }
    }
}
