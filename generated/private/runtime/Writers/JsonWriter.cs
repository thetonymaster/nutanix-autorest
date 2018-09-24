﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;

namespace Carbon.Json
{
    public class JsonWriter
    {
        const string indentation = "  ";  // 2 spaces

        private readonly bool pretty;
        private readonly TextWriter writer;

        protected int currentLevel = 0;

        public JsonWriter(TextWriter writer, bool pretty = true)
        {
            this.writer = writer ?? throw new ArgumentNullException(nameof(writer));
            this.pretty = pretty;
        }

        public void WriteNode(JsonNode node)
        {
            switch (node.Type)
            {
                case JsonType.Array    : WriteArray((IEnumerable<JsonNode>)node); break;
                case JsonType.Object   : WriteObject((JsonObject)node); break;

                // Primitives
                case JsonType.Binary   : WriteBinary((XBinary)node);    break;
                case JsonType.Boolean  : WriteBoolean((bool)node);      break;
                case JsonType.Date     : WriteDate((JsonDate)node);     break;
                case JsonType.Null     : WriteNull();                   break;
                case JsonType.Number   : WriteNumber((JsonNumber)node); break;
                case JsonType.String   : WriteString(node);             break;
            }
        }
        
        public void WriteArray(IEnumerable<JsonNode> array)
        {
            currentLevel++;

            writer.Write('[');

            bool doIndentation = false;

            if (pretty)
            {
                foreach (var node in array)
                {
                    if (node.Type == JsonType.Object || node.Type == JsonType.Array)
                    {
                        doIndentation = true;

                        break;
                    }
                }
            }

            bool isFirst = true;

            foreach (JsonNode node in array)
            {
                if (!isFirst) writer.Write(',');

                if (doIndentation)
                {
                    WriteIndent();
                }
                else if (pretty)
                {
                    writer.Write(' ');
                }

                WriteNode(node);

                isFirst = false;
            }

            currentLevel--;

            if (doIndentation)
            {
                WriteIndent();
            }
            else if (pretty)
            {
                writer.Write(' ');
            }

            writer.Write(']');
        }

        public void WriteIndent()
        {
            if (pretty)
            {
                writer.Write(Environment.NewLine);

                for (int level = 0; level < currentLevel; level++)
                {
                    writer.Write(indentation);
                }
            }
        }

        public void WriteObject(JsonObject obj)
        {
            currentLevel++;

            writer.Write('{');

            bool isFirst = true;

            foreach (var field in obj)
            {
                if (!isFirst) writer.Write(',');

                WriteIndent();

                WriteFieldName(field.Key);

                writer.Write(':');

                if (pretty)
                {
                    writer.Write(' ');
                }

                // Write the field value
                WriteNode(field.Value);

                isFirst = false;
            }

            currentLevel--;

            WriteIndent();

            writer.Write('}');
        }

        public void WriteFieldName(string fieldName)
        {
            writer.Write('"');

            JavaScriptEncoder.Default.Encode(writer, fieldName);

            writer.Write('"');
        }

        #region Primitives

        public void WriteBinary(XBinary value)
        {
            writer.Write('"');
            writer.Write(value.ToString());
            writer.Write('"');
        }

        public void WriteBoolean(bool value)
        {
            writer.Write(value ? "true" : "false");
        }

        public void WriteDate(JsonDate date)
        {
            if (date.ToDateTime().Year == 1)
            {
                WriteNull();
            }
            else
            {
                writer.Write('"');
                writer.Write(date.ToIsoString());
            writer.Write('"');
        }
        }

        public void WriteNull()
        {
            writer.Write("null");
        }

        public void WriteNumber(JsonNumber number)
        {
            if (number.Overflows)
            {
                writer.Write('"');
                writer.Write(number.Value);
                writer.Write('"');
            }
            else
            {
                writer.Write(number.Value);
            }
        }

        public void WriteString(string text)
        {
            if (text == null)
            {
                WriteNull();
            }
            else
            {
                writer.Write('"');

                JavaScriptEncoder.Default.Encode(writer, text);

                writer.Write('"');
            }
        }

        #endregion
    }
}


    // TODO: Replace with System.Text.Json when available
