using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using UnityEngine;

public class Parser
{
    public Parser() : base() { }

    public Speech[] Speeches { get; set; }
    public Npc[] Npcs { get; set; }

    public void LoadSpeeches(XDocument document)
    {
        Speeches = document.Root.Elements("speech").Select(s => new Speech()
        {
            Key = s.Attribute("key").Value,
            Text = s.Value,
        }).ToArray();
    }

    public void LoadNpcs(XDocument document)
    {
        Npcs = document.Root.Elements("npc").Select(n => new Npc()
        {
            Key = n.Attribute("key").Value,
            Speeches =
                n.Elements("speech").Select(s => new NpcSpeech()
                {
                    Key = s.Attribute("key").Value,
                    Expressions = ParseExpressions(s.Elements()),
                }).ToArray(),
        }).ToArray();
    }

    private SpeechExpression[] ParseExpressions(IEnumerable<XElement> elements)
    {
        List<SpeechExpression> items = new List<SpeechExpression>();

        foreach (XElement element in elements)
        {
            if (element.Name == "if" || element.Name == "ifnot")
            {
                SpeechExpression expression = new SpeechExpression();

                expression.Key = element.Attribute("key").Value;
                expression.Not = element.Name == "ifnot";
                expression.Expressions = ParseExpressions(element.Elements());

                items.Add(expression);
            }
        }

        return items.ToArray();
    }

    public Speech GetSpeech(Npc npc)
    {
        string key = npc.GetSpeechKey();

        Speech s = Speeches.FirstOrDefault(item => item.Key == key);

        if (s != null)
        {
            s.Set();
        }

        return s;
    }

    public override string ToString()
    {
        return string.Format("\r\n[Parser Speeches = {0}, Npcs = {1}]", string.Join(string.Empty, Speeches.Select(item => item.ToString()).ToArray()), string.Join(string.Empty, Npcs.Select(item => item.ToString()).ToArray()));
    }
}

public class Npc
{
    public Npc() : base() { }

    public string Key { get; set; }
    public NpcSpeech[] Speeches { get; set; }

    public string GetSpeechKey()
    {
        NpcSpeech s = Speeches.FirstOrDefault(item => item.IsValid());

        if (s != null)
        {
            return s.Key;
        }

        return null;
    }

    public override string ToString()
    {
        return string.Format("\r\n[Npc Key = {0}, Speeches = {1}]", Key, string.Join(string.Empty, Speeches.Select(item => item.ToString()).ToArray()));
    }
}

public class NpcSpeech
{
    public NpcSpeech() : base() { }

    public string Key { get; set; }
    public SpeechExpression[] Expressions { get; set; }

    public bool IsValid()
    {
        bool result = Expressions == null || Expressions.Length == 0;

        if (!result)
        {
            foreach (SpeechExpression exp in Expressions)
            {
                if (exp.IsValid())
                {
                    result = true;
                    break;
                }
            }
        }

        return result;
    }

    public override string ToString()
    {
        return string.Format("\r\n[NpcSpeech Key = {0}, Expressions = {1}]", Key, string.Join(string.Empty, Expressions.Select(item => item.ToString()).ToArray()));
    }
}

public class SpeechExpression
{
    public SpeechExpression() : base() { }

    public bool Not { get; set; }
    public string Key { get; set; }
    public SpeechExpression[] Expressions { get; set; }

    public bool IsValid()
    {
        bool result = false;

        result = Speech.IsSet(Key) && AnyChildIsValid();

        if (Not)
        {
            result = !result;
        }

        return result;
    }

    public bool AnyChildIsValid()
    {
        bool result = Expressions == null || Expressions.Length == 0;

        if (!result)
        {
            foreach (SpeechExpression exp in Expressions)
            {
                if (exp.IsValid())
                {
                    result = true;
                    break;
                }
            }
        }

        return result;
    }

    public override string ToString()
    {
        return string.Format("\r\n[SpeechExpression Key = {0}, Not = {1}, Expressions = {2}]", Key, Not, string.Join(string.Empty, Expressions.Select(item => item.ToString()).ToArray()));
    }
}

public class Speech
{
    static protected readonly Dictionary<string, bool> List = new Dictionary<string, bool>();

    public Speech() : base() { }

    public string Key { get; set; }
    public string Text { get; set; }

    public override string ToString()
    {
        return String.Format("\r\n[Speech key=\"{0}\", text=\"{1}\"]", Key, Text);
    }

    public void Set()
    {
        List[Key] = true;
    }

    public void UnSet()
    {
        if (List.ContainsKey(Key))
        {
            List.Remove(Key);
        }
    }

    public static bool IsSet(string key)
    {
        return List.ContainsKey(key) && List[key];
    }

    public static void Clear()
    {
        List.Clear();
    }
}
