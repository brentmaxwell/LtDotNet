// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NewPresetSavedStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from NewPresetSavedStatus.proto</summary>
public static partial class NewPresetSavedStatusReflection {

  #region Descriptor
  /// <summary>File descriptor for NewPresetSavedStatus.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static NewPresetSavedStatusReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpOZXdQcmVzZXRTYXZlZFN0YXR1cy5wcm90byI+ChROZXdQcmVzZXRTYXZl",
          "ZFN0YXR1cxISCgpwcmVzZXREYXRhGAEgAigJEhIKCnByZXNldFNsb3QYAiAC",
          "KAU="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::NewPresetSavedStatus), global::NewPresetSavedStatus.Parser, new[]{ "PresetData", "PresetSlot" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class NewPresetSavedStatus : pb::IMessage<NewPresetSavedStatus>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<NewPresetSavedStatus> _parser = new pb::MessageParser<NewPresetSavedStatus>(() => new NewPresetSavedStatus());
  private pb::UnknownFieldSet _unknownFields;
  private int _hasBits0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<NewPresetSavedStatus> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::NewPresetSavedStatusReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public NewPresetSavedStatus() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public NewPresetSavedStatus(NewPresetSavedStatus other) : this() {
    _hasBits0 = other._hasBits0;
    presetData_ = other.presetData_;
    presetSlot_ = other.presetSlot_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public NewPresetSavedStatus Clone() {
    return new NewPresetSavedStatus(this);
  }

  /// <summary>Field number for the "presetData" field.</summary>
  public const int PresetDataFieldNumber = 1;
  private readonly static string PresetDataDefaultValue = "";

  private string presetData_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string PresetData {
    get { return presetData_ ?? PresetDataDefaultValue; }
    set {
      presetData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }
  /// <summary>Gets whether the "presetData" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasPresetData {
    get { return presetData_ != null; }
  }
  /// <summary>Clears the value of the "presetData" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearPresetData() {
    presetData_ = null;
  }

  /// <summary>Field number for the "presetSlot" field.</summary>
  public const int PresetSlotFieldNumber = 2;
  private readonly static int PresetSlotDefaultValue = 0;

  private int presetSlot_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int PresetSlot {
    get { if ((_hasBits0 & 1) != 0) { return presetSlot_; } else { return PresetSlotDefaultValue; } }
    set {
      _hasBits0 |= 1;
      presetSlot_ = value;
    }
  }
  /// <summary>Gets whether the "presetSlot" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasPresetSlot {
    get { return (_hasBits0 & 1) != 0; }
  }
  /// <summary>Clears the value of the "presetSlot" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearPresetSlot() {
    _hasBits0 &= ~1;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as NewPresetSavedStatus);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(NewPresetSavedStatus other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (PresetData != other.PresetData) return false;
    if (PresetSlot != other.PresetSlot) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (HasPresetData) hash ^= PresetData.GetHashCode();
    if (HasPresetSlot) hash ^= PresetSlot.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (HasPresetData) {
      output.WriteRawTag(10);
      output.WriteString(PresetData);
    }
    if (HasPresetSlot) {
      output.WriteRawTag(16);
      output.WriteInt32(PresetSlot);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (HasPresetData) {
      output.WriteRawTag(10);
      output.WriteString(PresetData);
    }
    if (HasPresetSlot) {
      output.WriteRawTag(16);
      output.WriteInt32(PresetSlot);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (HasPresetData) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(PresetData);
    }
    if (HasPresetSlot) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(PresetSlot);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(NewPresetSavedStatus other) {
    if (other == null) {
      return;
    }
    if (other.HasPresetData) {
      PresetData = other.PresetData;
    }
    if (other.HasPresetSlot) {
      PresetSlot = other.PresetSlot;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          PresetData = input.ReadString();
          break;
        }
        case 16: {
          PresetSlot = input.ReadInt32();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          PresetData = input.ReadString();
          break;
        }
        case 16: {
          PresetSlot = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code