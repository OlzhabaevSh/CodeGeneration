﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGenerator
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class HttpServiceTemplate : HttpServiceTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 6 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
 if(IsModule)
{ 
            
            #line default
            #line hidden
            this.Write("export \r\n");
            
            #line 9 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("namespace ");
            
            #line 10 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 11 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
 if (IsGenerateModel)
{ 
            
            #line default
            #line hidden
            this.Write("\texport interface I");
            
            #line 13 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 14 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
 foreach(var prop in Type.Properties)
{ 
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 16 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Key));
            
            #line default
            #line hidden
            this.Write(": ");
            
            #line 16 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Value));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 17 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t}\r\n\r\n\texport class ");
            
            #line 20 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write(" implements ");
            
            #line 20 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".I");
            
            #line 20 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 21 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
 foreach(var prop in Type.Properties) 
{ 
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 23 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Key));
            
            #line default
            #line hidden
            this.Write(": ");
            
            #line 23 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Value));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 24 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\tconstructor(config: ");
            
            #line 26 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".I");
            
            #line 26 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write("){\r\n\t\t\tangular.copy(this, config);\r\n\t\t}\r\n\t}\r\n\r\n\texport class ");
            
            #line 31 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("Service { \r\n\r\n    private _url: string = \"/api/");
            
            #line 33 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n    constructor(private $http: ng.IHttpService) { \r\n    }\r\n\r\n    Get(): ng." +
                    "IHttpPromise<Array<");
            
            #line 38 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".I");
            
            #line 38 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write(">>;\r\n\r\n    Get(id: number): ng.IHttpPromise<");
            
            #line 40 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".I");
            
            #line 40 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write(">;\r\n\r\n    Get(id?: number): ng.IHttpPromise<Array<");
            
            #line 42 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".I");
            
            #line 42 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write(@">> { 
        if (id == undefined) {
            return this.$http({
                url: this._url,
                method: 'get'
            });
        }
        else { 
            return this.$http({
                url: this._url + ""/"" + id,
                method: 'get'
            });
        }
    }
	
    GetWithQuery(options: Array<string>): Array<");
            
            #line 57 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".I");
            
            #line 57 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write(@"> {
        let url = this._url + ""?"";

        if (options.length > 0) { 
            options.forEach((item) => {
                url += item + ""&""
            });
            url = url.slice(url.length - 1, 1);
        }

        return this.$http({
            url: url,
            method: 'get'
        });
    }

    Post(data: ");
            
            #line 73 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".I");
            
            #line 73 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write("): ng.IHttpPromise<");
            
            #line 73 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".I");
            
            #line 73 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write("> { \r\n        return this.$http({\r\n            url: this._url,\r\n            metho" +
                    "d: \'post\'\r\n        });\r\n    }\r\n\r\n    Put(id: number, data: ");
            
            #line 80 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".I");
            
            #line 80 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write("): ng.IHttpPromise<");
            
            #line 80 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".I");
            
            #line 80 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write("> { \r\n        return this.$http({\r\n            url: this._url + \"/\" + id,\r\n      " +
                    "      method: \'put\',\r\n            data: data\r\n        });\r\n    }\r\n\r\n    Delete(i" +
                    "d: number): ng.IHttpPromise<");
            
            #line 88 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".I");
            
            #line 88 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write("> { \r\n        return this.$http({\r\n            url: this._url + \"/\" + id,\r\n      " +
                    "      method: \'delete\'\r\n        });\r\n    }\r\n\r\n}\r\n\r\n");
            
            #line 97 "C:\Users\chingiz\documents\visual studio 2015\Projects\CodeGeneration\CodeGenerator\HttpServiceTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class HttpServiceTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
