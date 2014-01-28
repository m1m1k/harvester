using System;
using System.Text;
using System.Diagnostics;
using Diagnostics.Tracing;
using Diagnostics.Tracing.Parsers;
using Address = System.UInt64;
using System.Runtime.InteropServices;

// This code was automatically generated by the TraceParserGen tool, which converts
// an ETW event manifest into strongly typed C# classes.
namespace Diagnostics.Tracing.Parsers
{

    public sealed class JSDumpHeapTraceEventParser : TraceEventParser 
    {
        public static string ProviderName = "Microsoft-IE-JSDumpHeap";
        public static Guid ProviderGuid = new Guid(unchecked((int) 0x7f8e35ca), unchecked((short) 0x68e8), unchecked((short) 0x41b9), 0x86, 0xfe, 0xd6, 0xad, 0xc5, 0xb3, 0x27, 0xe7);
        public enum Keywords : long
        {
            jsdumpheap = 0x00000020,
            jsdumpheapEnvelopeOnly = 0x80000000,
        };

        public JSDumpHeapTraceEventParser(TraceEventSource source) : base(source) {}

        public event Action<SettingsTraceData> JSDumpHeapEnvelopeStart
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new SettingsTraceData(value, 1, 321, "JSDumpHeapEnvelope", JSDumpHeapEnvelopeTaskGuid, 1, "Start", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<SummaryTraceData> JSDumpHeapEnvelopeStop
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new SummaryTraceData(value, 2, 321, "JSDumpHeapEnvelope", JSDumpHeapEnvelopeTaskGuid, 2, "Stop", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<BulkNodeTraceData> JSDumpHeapBulkNode
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new BulkNodeTraceData(value, 3, 323, "JSDumpHeapBulkNode", JSDumpHeapBulkNodeTaskGuid, 0, "Info", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<BulkAttributeTraceData> JSDumpHeapBulkAttribute
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new BulkAttributeTraceData(value, 4, 324, "JSDumpHeapBulkAttribute", JSDumpHeapBulkAttributeTaskGuid, 0, "Info", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<BulkEdgeTraceData> JSDumpHeapBulkEdge
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new BulkEdgeTraceData(value, 5, 325, "JSDumpHeapBulkEdge", JSDumpHeapBulkEdgeTaskGuid, 0, "Info", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<StringTableTraceData> JSDumpHeapStringTable
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new StringTableTraceData(value, 6, 326, "JSDumpHeapStringTable", JSDumpHeapStringTableTaskGuid, 0, "Info", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<DoubleTableTraceData> JSDumpHeapDoubleTable
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new DoubleTableTraceData(value, 7, 327, "JSDumpHeapDoubleTable", JSDumpHeapDoubleTableTaskGuid, 0, "Info", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }

       #region Event ID Definitions
        public const TraceEventID JSDumpHeapEnvelopeStartEventID = (TraceEventID) 1;
        public const TraceEventID JSDumpHeapEnvelopeStopEventID = (TraceEventID) 2;
        public const TraceEventID JSDumpHeapBulkNodeEventID = (TraceEventID) 3;
        public const TraceEventID JSDumpHeapBulkAttributeEventID = (TraceEventID) 4;
        public const TraceEventID JSDumpHeapBulkEdgeEventID = (TraceEventID) 5;
        public const TraceEventID JSDumpHeapStringTableEventID = (TraceEventID) 6;
        public const TraceEventID JSDumpHeapDoubleTableEventID = (TraceEventID) 7;
       #endregion

    #region private
        private static Guid JSDumpHeapEnvelopeTaskGuid = new Guid(unchecked((int) 0xfff80bb3), unchecked((short) 0x0541), unchecked((short) 0x4423), 0xb2, 0x6b, 0x8c, 0x4a, 0x5a, 0xf9, 0x06, 0xff);
        private static Guid JSDumpHeapBulkNodeTaskGuid = new Guid(unchecked((int) 0x89b4a9e6), unchecked((short) 0x156f), unchecked((short) 0x4ff2), 0x8c, 0x93, 0xcd, 0x86, 0xb1, 0xbc, 0xe9, 0xa4);
        private static Guid JSDumpHeapBulkAttributeTaskGuid = new Guid(unchecked((int) 0xb171ef0b), unchecked((short) 0xd1fb), unchecked((short) 0x4901), 0x98, 0x47, 0xe1, 0x3d, 0x58, 0x3b, 0xfa, 0x86);
        private static Guid JSDumpHeapBulkEdgeTaskGuid = new Guid(unchecked((int) 0xec5809c8), unchecked((short) 0xef06), unchecked((short) 0x456c), 0xbe, 0x69, 0xe8, 0xdc, 0xdf, 0x75, 0x54, 0xba);
        private static Guid JSDumpHeapStringTableTaskGuid = new Guid(unchecked((int) 0x8a019204), unchecked((short) 0x6cc0), unchecked((short) 0x41f3), 0x8f, 0xae, 0xe1, 0x90, 0xdd, 0xfd, 0x05, 0xa7);
        private static Guid JSDumpHeapDoubleTableTaskGuid = new Guid(unchecked((int) 0xeaa70a14), unchecked((short) 0xd1c3), unchecked((short) 0x4939), 0x8c, 0xa7, 0x39, 0x3c, 0x2f, 0x75, 0xfa, 0x58);
    #endregion
    }

    public sealed class SettingsTraceData : TraceEvent
    {
        public int Version { get { return GetInt32At(0); } }
        public int MaxStringLength { get { return GetInt32At(4); } }
        public bool IsTypeNamePrivate { get { return GetInt32At(8) != 0; } }
        public bool IsEdgeStringValuePrivate { get { return GetInt32At(12) != 0; } }
        public bool IsEdgeNumberValuePrivate { get { return GetInt32At(16) != 0; } }
        public bool IsAttributeStringValuePrivate { get { return GetInt32At(20) != 0; } }
        public bool IsAttributeNumberValuePrivate { get { return GetInt32At(24) != 0; } }

        #region Private
        internal SettingsTraceData(Action<SettingsTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
        internal  protected override void Dispatch()
        {
            Action(this);
        }
        internal  protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != 28));
            Debug.Assert(!(Version > 0 && EventDataLength < 28));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("Version", Version);
             sb.XmlAttrib("MaxStringLength", MaxStringLength);
             sb.XmlAttrib("IsTypeNamePrivate", IsTypeNamePrivate);
             sb.XmlAttrib("IsEdgeStringValuePrivate", IsEdgeStringValuePrivate);
             sb.XmlAttrib("IsEdgeNumberValuePrivate", IsEdgeNumberValuePrivate);
             sb.XmlAttrib("IsAttributeStringValuePrivate", IsAttributeStringValuePrivate);
             sb.XmlAttrib("IsAttributeNumberValuePrivate", IsAttributeNumberValuePrivate);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "Version", "MaxStringLength", "IsTypeNamePrivate", "IsEdgeStringValuePrivate", "IsEdgeNumberValuePrivate", "IsAttributeStringValuePrivate", "IsAttributeNumberValuePrivate"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return Version;
                case 1:
                    return MaxStringLength;
                case 2:
                    return IsTypeNamePrivate;
                case 3:
                    return IsEdgeStringValuePrivate;
                case 4:
                    return IsEdgeNumberValuePrivate;
                case 5:
                    return IsAttributeStringValuePrivate;
                case 6:
                    return IsAttributeNumberValuePrivate;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<SettingsTraceData> Action;
        #endregion
    }
    public sealed class SummaryTraceData : TraceEvent
    {
        public int HrResult { get { return GetInt32At(0); } }
        public int NodeCount { get { return GetInt32At(4); } }
        public int EdgeCount { get { return GetInt32At(8); } }
        public int AttributeCount { get { return GetInt32At(12); } }
        public int NumberCount { get { return GetInt32At(16); } }
        public int StringCount { get { return GetInt32At(20); } }

        #region Private
        internal SummaryTraceData(Action<SummaryTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
        internal  protected override void Dispatch()
        {
            Action(this);
        }
        internal  protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != 24));
            Debug.Assert(!(Version > 0 && EventDataLength < 24));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("HrResult", HrResult);
             sb.XmlAttrib("NodeCount", NodeCount);
             sb.XmlAttrib("EdgeCount", EdgeCount);
             sb.XmlAttrib("AttributeCount", AttributeCount);
             sb.XmlAttrib("NumberCount", NumberCount);
             sb.XmlAttrib("StringCount", StringCount);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "HrResult", "NodeCount", "EdgeCount", "AttributeCount", "NumberCount", "StringCount"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return HrResult;
                case 1:
                    return NodeCount;
                case 2:
                    return EdgeCount;
                case 3:
                    return AttributeCount;
                case 4:
                    return NumberCount;
                case 5:
                    return StringCount;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<SummaryTraceData> Action;
        #endregion
    }

    public sealed class BulkNodeTraceData : TraceEvent
    {
        public int Index { get { return GetInt32At(0); } }
        public int Count { get { return GetInt32At(4); } }
        public unsafe BulkNodeElement* Values(int i, BulkNodeElement* buffer)
        {
            Debug.Assert(0 <= i && i < Count);
            if (PointerSize != 8)
            {
                BulkNodeElement32* basePtr = (BulkNodeElement32*)(((byte*)DataStart) + 8);
                BulkNodeElement32* value = basePtr + i;

                buffer->Id = value->Id;
                buffer->Size = value->Size;
                buffer->Address = value->Address;
                buffer->TypeNameId = value->TypeNameId;
                buffer->Flags = value->Flags;
                buffer->AttributeCount = value->AttributeCount;
                buffer->EdgeCount = value->EdgeCount;
                return buffer;
            }
            else
            {
                BulkNodeElement* basePtr = (BulkNodeElement*)(((byte*)DataStart) + 8);
                return basePtr + i;
            }
        }
        public unsafe BulkNodeElement Val(int i)
        {
            BulkNodeElement ret = new BulkNodeElement();
            return *Values(i, &ret);
        }
        #region Private
        internal BulkNodeTraceData(Action<BulkNodeTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
        internal protected override void Dispatch()
        {
            Action(this);
        }
        unsafe internal protected override void Validate()
        {
            Debug.Assert(!(EventDataLength < 8));
            Debug.Assert(!(Version == 0 && EventDataLength != 8 + Count * (PointerSize == 8 ? sizeof(BulkNodeElement) : sizeof(BulkNodeElement32))));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
            Prefix(sb);
            sb.XmlAttrib("Index", Index);
            sb.XmlAttrib("Count", Count);
            sb.Append("/>");
            return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "Index", "Count" };
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return Index;
                case 1:
                    return Count;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<BulkNodeTraceData> Action;
        #endregion
    }

    /// <summary>
    /// This is the layout on a 32 bit system.   
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BulkNodeElement32
    {
        public uint Id;
        public int Size;
        public uint Address;
        public int TypeNameId;
        public ObjectFlags Flags;
        public ushort AttributeCount;
        public int EdgeCount;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BulkNodeElement
    {
        public ulong Id;
        public int Size;
        public ulong Address;
        public int TypeNameId;
        public ObjectFlags Flags;
        public ushort AttributeCount;
        public int EdgeCount;
    }

    // TODO change casing?  This is the PROFILER_HEAP_OBJECT_FLAGS enum 
    [Flags]
    public enum ObjectFlags : uint
    {  
        NEW_OBJECT	= 0x1,  
        IS_ROOT	= 0x2,  
        SITE_CLOSED	= 0x4,  
        EXTERNAL	= 0x8,  
        EXTERNAL_UNKNOWN	= 0x10,  
        EXTERNAL_DISPATCH	= 0x20,  
        SIZE_APPROXIMATE	= 0x40,  
        SIZE_UNAVAILABLE	= 0x80,  
        NEW_STATE_UNAVAILABLE	= 0x100,  
        WINRT_INSTANCE	= 0x200,  
        WINRT_RUNTIMECLASS	= 0x400,  
        WINRT_DELEGATE	= 0x800,  
        WINRT_NAMESPACE	= 0x1000,
        WINRT = (WINRT_INSTANCE|WINRT_RUNTIMECLASS|WINRT_DELEGATE|WINRT_NAMESPACE)
    };

    public sealed class BulkAttributeTraceData : TraceEvent
    {
        public int Index { get { return GetInt32At(0); } }
        public int Count { get { return GetInt32At(4); } }
        public unsafe BulkAttributeElement* Values(int i, BulkAttributeElement* buffer)
        {
            Debug.Assert(0 <= i && i < Count);
            if (PointerSize != 8)
            {
                BulkAttributeElement32* basePtr = (BulkAttributeElement32*)(((byte*)DataStart) + 8);
                BulkAttributeElement32* value = basePtr + i;

                buffer->Type = value->Type;
                buffer->Value = value->Value;
                return buffer;
            }
            else
            {
                BulkAttributeElement* basePtr = (BulkAttributeElement*)(((byte*)DataStart) + 8);
                return basePtr + i;
            }
        }

        #region Private
        internal BulkAttributeTraceData(Action<BulkAttributeTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
        internal protected override void Dispatch()
        {
            Action(this);
        }
        internal unsafe protected override void Validate()
        {
            Debug.Assert(!(EventDataLength < 8));
            Debug.Assert(!(Version == 0 && EventDataLength != 8 + Count * (PointerSize == 8 ? sizeof(BulkAttributeElement) : sizeof(BulkAttributeElement32))));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
            Prefix(sb);
            sb.XmlAttrib("Index", Index);
            sb.XmlAttrib("Count", Count);
            sb.Append("/>");
            return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "Index", "Count" };
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return Index;
                case 1:
                    return Count;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<BulkAttributeTraceData> Action;
        #endregion
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BulkAttributeElement32
    {
        public AttributeType Type;
        public uint Value;           // Might be string index into the string table. 
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BulkAttributeElement
    {
        public AttributeType Type;
        public ulong Value;           // Might be string index into the string table. 
    }

    public enum AttributeType : ushort
    {
        DOMTagName,                 // Does not seem to be used yet
        DOMId,                      // Does not seem to be used yet
        DOMClass,                   // Does not seem to be used yet
        DOMSrc,                     // Does not seem to be used yet
        ElementAttributesSize,      // Value is a number
        Scope,                      // Value is a number
        Prototype,                  // Value is a number
        FunctionName,               // Value is a string ID
        TextChildrenSize,           // Value is a number
        Max
    };

    public sealed class BulkEdgeTraceData : TraceEvent
    {
        public int Index { get { return GetInt32At(0); } }
        public int Count { get { return GetInt32At(4); } }
        public unsafe BulkEdgeElement* Values(int i, BulkEdgeElement* buffer)
        {
            Debug.Assert(0 <= i && i < Count);
            if (PointerSize != 8)
            {
                BulkEdgeElement32* basePtr = (BulkEdgeElement32*)(((byte*)DataStart) + 8);
                BulkEdgeElement32* value = basePtr + i;

                buffer->RelationshipType = value->RelationshipType;
                buffer->TargetType = value->TargetType;
                buffer->NameId = value->NameId;
                buffer->Value = value->Value;
                return buffer;
            }
            else
            {
                BulkEdgeElement* basePtr = (BulkEdgeElement*)(((byte*)DataStart) + 8);
                return basePtr + i;
            }
        }

        #region Private
        internal BulkEdgeTraceData(Action<BulkEdgeTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
        internal unsafe protected override void Dispatch()
        {
            Action(this);
        }
        internal unsafe protected override void Validate()
        {
            Debug.Assert(!(EventDataLength < 8));
            Debug.Assert(!(Version == 0 && EventDataLength != 8 + Count * (PointerSize == 8 ? sizeof(BulkEdgeElement) : sizeof(BulkEdgeElement32))));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
            Prefix(sb);
            sb.XmlAttrib("Index", Index);
            sb.XmlAttrib("Count", Count);
            sb.Append("/>");
            return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "Index", "Count" };
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return Index;
                case 1:
                    return Count;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<BulkEdgeTraceData> Action;
        #endregion
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BulkEdgeElement32
    {
        public EdgeRelationshipType RelationshipType;
        public EdgeTargetType TargetType;
        public int NameId;
        public uint Value;          // index into string table (TargetType==string), the double table (TargetType==TargetTypeNumber) or node table (other)
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BulkEdgeElement
    {
        public EdgeRelationshipType RelationshipType;
        public EdgeTargetType TargetType;
        public int NameId;
        public ulong Value;          // index into string table (TargetType==string), the double table (TargetType==TargetTypeNumber) or node table (other)
    }

    public enum EdgeRelationshipType : byte
    {
        Prototype,          
        Scope,
        InternalProperty,
        NamedProperty,
        IndexedProperty,    // The object is an array, The Name ID is the index into that array.   (Not the index in the string table)
        Event,
        RelationShip,       // Some other relationship (typically a DOM tag or class) The NameId tells you the relationship. 
        Max
    }

    public enum EdgeTargetType : byte
    {
        Number,         // Value is index into double table
        String,         // Value is ???
        BSTR,           // Value is index into string table
        Object,         // Value is Node Address
        External,       // Value is Node Address
        Max
    }

    public sealed class StringTableTraceData : TraceEvent
    {
        public int Index { get { return GetInt32At(0); } }
        public int Count { get { return GetInt32At(4); } }
        public string StringEntry(int i) {
            Debug.Assert(0 <= i && i < Count);
            // Perf Remember the last place we were and look from there if possible.  
            // This handles the common case 
            int idx = m_lastStrIdx;
            int offset = m_lastStrOffset;
            if (i < idx)
            {
                idx = 0;
                offset = 8;
            }
            while (idx < i)
            {
                idx++;
                offset = SkipUnicodeString(offset);
            }

            var ret = GetUnicodeStringAt(offset);
            // Point at the next offset.  
            m_lastStrIdx = i + 1;
            m_lastStrOffset = offset + 2*(ret.Length + 1);
            return ret;
        }

        #region Private
        internal StringTableTraceData(Action<StringTableTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
            this.m_lastStrOffset = 8;
        }
        internal protected override void Dispatch()
        {
            Action(this);
        }
        internal protected override void Validate()
        {
            Debug.Assert(!(EventDataLength < 8));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
            Prefix(sb);
            sb.XmlAttrib("Index", Index);
            sb.XmlAttrib("Count", Count);
            sb.Append("/>");
            return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "Index", "Count" };
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return Index;
                case 1:
                    return Count;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<StringTableTraceData> Action;

            // For efficient string lookup
        private int m_lastStrIdx;
        private int m_lastStrOffset;
        #endregion
    }
    public unsafe sealed class DoubleTableTraceData : TraceEvent
    {
        public int Index { get { return GetInt32At(0); } }
        public int Count { get { return GetInt32At(4); } }
        public double DoubleEntry(int i)
        {
            Debug.Assert(0 <= i && i < Count);
            double* basePtr = (double*)(((byte*)DataStart) + 8);
            return basePtr[i];
        }

        #region Private
        internal DoubleTableTraceData(Action<DoubleTableTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
        internal protected override void Dispatch()
        {
            Action(this);
        }
        internal protected override void Validate()
        {
            Debug.Assert(!(EventDataLength < 8));
            Debug.Assert(!(Version == 0 && EventDataLength != 8 + Count * 8));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
            Prefix(sb);
            sb.XmlAttrib("Index", Index);
            sb.XmlAttrib("Count", Count);
            sb.Append("/>");
            return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "Index", "Count" };
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return Index;
                case 1:
                    return Count;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<DoubleTableTraceData> Action;
        #endregion
    }

}
