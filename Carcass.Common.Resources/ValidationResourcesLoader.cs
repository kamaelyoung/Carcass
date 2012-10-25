﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carcass.Common.Resources
{
    public class ValidationResourcesLoader
    {
        public static string GetResources(CultureInfo locale)
        {
            var sb = new StringBuilder();
            var resources = ValidationResources.ResourceManager;
            sb.AppendFormat("// Translated messages for the jQuery validation plugin. \r\n// Locale: {0}, {1} \r\n", locale.TwoLetterISOLanguageName, locale.NativeName);
            sb.Append("jQuery.extend(jQuery.validator.messages, {\r\n");
            sb.AppendFormat("\"{0}\": jQuery.validator.format({1}),", "required", JavaScriptHelper.EncodeJavaScript(resources.GetString("Requred", locale)) );

            sb.AppendFormat("\"{0}\": {1},\n", "remote", JavaScriptHelper.EncodeJavaScript(resources.GetString("Remote", locale)));
            sb.AppendFormat("\"{0}\": {1},\n", "email", JavaScriptHelper.EncodeJavaScript(resources.GetString("Email", locale)));
            sb.AppendFormat("\"{0}\": {1},\n", "url", JavaScriptHelper.EncodeJavaScript(resources.GetString("Url", locale)));
            sb.AppendFormat("\"{0}\": {1},\n", "date", JavaScriptHelper.EncodeJavaScript(resources.GetString("Date", locale)));
            sb.AppendFormat("\"{0}\": {1},\n", "time", JavaScriptHelper.EncodeJavaScript(resources.GetString("Time", locale)));
            sb.AppendFormat("\"{0}\": {1},\n", "dateISO", JavaScriptHelper.EncodeJavaScript(resources.GetString("DateISO", locale)));
            sb.AppendFormat("\"{0}\": {1},\n", "number", JavaScriptHelper.EncodeJavaScript(resources.GetString("Number", locale)));
            sb.AppendFormat("\"{0}\": {1},\n", "digits", JavaScriptHelper.EncodeJavaScript(resources.GetString("Digits", locale)));
            sb.AppendFormat("\"{0}\": {1},\n", "creditcard", JavaScriptHelper.EncodeJavaScript(resources.GetString("Creditcard", locale)));
            sb.AppendFormat("\"{0}\": {1},\n", "equalTo", JavaScriptHelper.EncodeJavaScript(resources.GetString("EqualTo", locale)));
            sb.AppendFormat("\"{0}\": {1},\n", "accept", JavaScriptHelper.EncodeJavaScript(resources.GetString("Accept", locale)));

            sb.AppendFormat("\"{0}\": jQuery.validator.format({1}),\n", "maxlength", JavaScriptHelper.EncodeJavaScript(resources.GetString("MaxLength", locale)) );
            sb.AppendFormat("\"{0}\": jQuery.validator.format({1}),\n", "minlength", JavaScriptHelper.EncodeJavaScript(resources.GetString("MinLength", locale)));
            sb.AppendFormat("\"{0}\": jQuery.validator.format({1}),\n", "rangelength", JavaScriptHelper.EncodeJavaScript(resources.GetString("RangeLength", locale)));
            sb.AppendFormat("\"{0}\": jQuery.validator.format({1}),\n", "range", JavaScriptHelper.EncodeJavaScript(resources.GetString("Range", locale)));
            sb.AppendFormat("\"{0}\": jQuery.validator.format({1}),\n", "max", JavaScriptHelper.EncodeJavaScript(resources.GetString("Max", locale)));
            sb.AppendFormat("\"{0}\": jQuery.validator.format({1})", "min", JavaScriptHelper.EncodeJavaScript(resources.GetString("Min", locale)) );

            sb.Append("});");
            return sb.ToString();
        }
    }
}
