// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Availability.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Microsoft.LocalForwarder.Library.Inputs.Contracts {

  /// <summary>Holder for reflection information generated from Availability.proto</summary>
  public static partial class AvailabilityReflection {

    #region Descriptor
    /// <summary>File descriptor for Availability.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvailabilityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJBdmFpbGFiaWxpdHkucHJvdG8SCWNvbnRyYWN0cxomaW5jbHVkZS9nb29n",
            "bGUvcHJvdG9idWYvZHVyYXRpb24ucHJvdG8i/wIKDEF2YWlsYWJpbGl0eRIL",
            "CgN2ZXIYASABKAUSCgoCaWQYAiABKAkSDAoEbmFtZRgDIAEoCRIrCghkdXJh",
            "dGlvbhgEIAEoCzIZLmdvb2dsZS5wcm90b2J1Zi5EdXJhdGlvbhIPCgdzdWNj",
            "ZXNzGAUgASgIEhMKC3J1bkxvY2F0aW9uGAYgASgJEg8KB21lc3NhZ2UYByAB",
            "KAkSOwoKcHJvcGVydGllcxgIIAMoCzInLmNvbnRyYWN0cy5BdmFpbGFiaWxp",
            "dHkuUHJvcGVydGllc0VudHJ5Ej8KDG1lYXN1cmVtZW50cxgJIAMoCzIpLmNv",
            "bnRyYWN0cy5BdmFpbGFiaWxpdHkuTWVhc3VyZW1lbnRzRW50cnkaMQoPUHJv",
            "cGVydGllc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAEa",
            "MwoRTWVhc3VyZW1lbnRzRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIg",
            "ASgBOgI4AUI0qgIxTWljcm9zb2Z0LkxvY2FsRm9yd2FyZGVyLkxpYnJhcnku",
            "SW5wdXRzLkNvbnRyYWN0c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Microsoft.LocalForwarder.Library.Inputs.Contracts.Availability), global::Microsoft.LocalForwarder.Library.Inputs.Contracts.Availability.Parser, new[]{ "Ver", "Id", "Name", "Duration", "Success", "RunLocation", "Message", "Properties", "Measurements" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Availability : pb::IMessage<Availability> {
    private static readonly pb::MessageParser<Availability> _parser = new pb::MessageParser<Availability>(() => new Availability());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Availability> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Microsoft.LocalForwarder.Library.Inputs.Contracts.AvailabilityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Availability() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Availability(Availability other) : this() {
      ver_ = other.ver_;
      id_ = other.id_;
      name_ = other.name_;
      duration_ = other.duration_ != null ? other.duration_.Clone() : null;
      success_ = other.success_;
      runLocation_ = other.runLocation_;
      message_ = other.message_;
      properties_ = other.properties_.Clone();
      measurements_ = other.measurements_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Availability Clone() {
      return new Availability(this);
    }

    /// <summary>Field number for the "ver" field.</summary>
    public const int VerFieldNumber = 1;
    private int ver_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Ver {
      get { return ver_; }
      set {
        ver_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Duration duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 5;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "runLocation" field.</summary>
    public const int RunLocationFieldNumber = 6;
    private string runLocation_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RunLocation {
      get { return runLocation_; }
      set {
        runLocation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 7;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "properties" field.</summary>
    public const int PropertiesFieldNumber = 8;
    private static readonly pbc::MapField<string, string>.Codec _map_properties_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 66);
    private readonly pbc::MapField<string, string> properties_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Properties {
      get { return properties_; }
    }

    /// <summary>Field number for the "measurements" field.</summary>
    public const int MeasurementsFieldNumber = 9;
    private static readonly pbc::MapField<string, double>.Codec _map_measurements_codec
        = new pbc::MapField<string, double>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForDouble(17), 74);
    private readonly pbc::MapField<string, double> measurements_ = new pbc::MapField<string, double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, double> Measurements {
      get { return measurements_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Availability);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Availability other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ver != other.Ver) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (!object.Equals(Duration, other.Duration)) return false;
      if (Success != other.Success) return false;
      if (RunLocation != other.RunLocation) return false;
      if (Message != other.Message) return false;
      if (!Properties.Equals(other.Properties)) return false;
      if (!Measurements.Equals(other.Measurements)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ver != 0) hash ^= Ver.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (duration_ != null) hash ^= Duration.GetHashCode();
      if (Success != false) hash ^= Success.GetHashCode();
      if (RunLocation.Length != 0) hash ^= RunLocation.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      hash ^= Properties.GetHashCode();
      hash ^= Measurements.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Ver != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Ver);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (duration_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Duration);
      }
      if (Success != false) {
        output.WriteRawTag(40);
        output.WriteBool(Success);
      }
      if (RunLocation.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(RunLocation);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Message);
      }
      properties_.WriteTo(output, _map_properties_codec);
      measurements_.WriteTo(output, _map_measurements_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ver != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Ver);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (duration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Duration);
      }
      if (Success != false) {
        size += 1 + 1;
      }
      if (RunLocation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RunLocation);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      size += properties_.CalculateSize(_map_properties_codec);
      size += measurements_.CalculateSize(_map_measurements_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Availability other) {
      if (other == null) {
        return;
      }
      if (other.Ver != 0) {
        Ver = other.Ver;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.duration_ != null) {
        if (duration_ == null) {
          duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Duration.MergeFrom(other.Duration);
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      if (other.RunLocation.Length != 0) {
        RunLocation = other.RunLocation;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      properties_.Add(other.properties_);
      measurements_.Add(other.measurements_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Ver = input.ReadInt32();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            if (duration_ == null) {
              duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(duration_);
            break;
          }
          case 40: {
            Success = input.ReadBool();
            break;
          }
          case 50: {
            RunLocation = input.ReadString();
            break;
          }
          case 58: {
            Message = input.ReadString();
            break;
          }
          case 66: {
            properties_.AddEntriesFrom(input, _map_properties_codec);
            break;
          }
          case 74: {
            measurements_.AddEntriesFrom(input, _map_measurements_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
