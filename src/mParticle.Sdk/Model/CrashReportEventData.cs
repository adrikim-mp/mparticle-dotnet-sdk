using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = mParticle.Sdk.Client.OpenAPIDateConverter;

namespace mParticle.Sdk.Model
{
    /// <summary>
    /// CrashReportEventData
    /// </summary>
    [DataContract]
    public partial class CrashReportEventData :  IEquatable<CrashReportEventData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrashReportEventData" /> class.
        /// </summary>
        /// <param name="timestampUnixtimeMs">timestampUnixtimeMs.</param>
        /// <param name="sourceMessageId">sourceMessageId.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="sessionUuid">sessionUuid.</param>
        /// <param name="sessionStartUnixtimeMs">sessionStartUnixtimeMs.</param>
        /// <param name="eventStartUnixtimeMs">eventStartUnixtimeMs.</param>
        /// <param name="customAttributes">customAttributes.</param>
        /// <param name="location">location.</param>
        /// <param name="deviceCurrentState">deviceCurrentState.</param>
        /// <param name="isGoalDefined">isGoalDefined.</param>
        /// <param name="lifetimeValueChange">lifetimeValueChange.</param>
        /// <param name="lifetimeValueAttributeName">lifetimeValueAttributeName.</param>
        /// <param name="dataConnectionType">dataConnectionType.</param>
        /// <param name="eventNum">eventNum.</param>
        /// <param name="viewController">viewController.</param>
        /// <param name="isMainThread">isMainThread.</param>
        /// <param name="canonicalName">canonicalName.</param>
        /// <param name="eventSystemNotificationInfo">eventSystemNotificationInfo.</param>
        /// <param name="breadcrumbs">breadcrumbs.</param>
        /// <param name="className">className.</param>
        /// <param name="severity">severity.</param>
        /// <param name="message">message.</param>
        /// <param name="stackTrace">stackTrace.</param>
        /// <param name="exceptionHandled">exceptionHandled.</param>
        /// <param name="topmostContext">topmostContext.</param>
        /// <param name="plCrashReportFileBase64">plCrashReportFileBase64.</param>
        /// <param name="iosImageBaseAddress">iosImageBaseAddress.</param>
        /// <param name="iosImageSize">iosImageSize.</param>
        /// <param name="sessionNumber">sessionNumber.</param>
        public CrashReportEventData(int timestampUnixtimeMs = default(int), string sourceMessageId = default(string), long sessionId = default(long), string sessionUuid = default(string), int sessionStartUnixtimeMs = default(int), int eventStartUnixtimeMs = default(int), Dictionary<string, string> customAttributes = default(Dictionary<string, string>), GeoLocation location = default(GeoLocation), DeviceCurrentState deviceCurrentState = default(DeviceCurrentState), bool isGoalDefined = default(bool), bool lifetimeValueChange = default(bool), string lifetimeValueAttributeName = default(string), string dataConnectionType = default(string), int eventNum = default(int), string viewController = default(string), bool isMainThread = default(bool), string canonicalName = default(string), EventSystemNotificationInfo eventSystemNotificationInfo = default(EventSystemNotificationInfo), Collection<string> breadcrumbs = default(Collection<string>), string className = default(string), string severity = default(string), string message = default(string), string stackTrace = default(string), bool exceptionHandled = default(bool), string topmostContext = default(string), string plCrashReportFileBase64 = default(string), int iosImageBaseAddress = default(int), int iosImageSize = default(int), int sessionNumber = default(int))
        {
            this.TimestampUnixtimeMs = timestampUnixtimeMs;
            this.SourceMessageId = sourceMessageId;
            this.SessionId = sessionId;
            this.SessionUuid = sessionUuid;
            this.SessionStartUnixtimeMs = sessionStartUnixtimeMs;
            this.EventStartUnixtimeMs = eventStartUnixtimeMs;
            this.CustomAttributes = customAttributes;
            this.Location = location;
            this.DeviceCurrentState = deviceCurrentState;
            this.IsGoalDefined = isGoalDefined;
            this.LifetimeValueChange = lifetimeValueChange;
            this.LifetimeValueAttributeName = lifetimeValueAttributeName;
            this.DataConnectionType = dataConnectionType;
            this.EventNum = eventNum;
            this.ViewController = viewController;
            this.IsMainThread = isMainThread;
            this.CanonicalName = canonicalName;
            this.EventSystemNotificationInfo = eventSystemNotificationInfo;
            this.Breadcrumbs = breadcrumbs;
            this.ClassName = className;
            this.Severity = severity;
            this.Message = message;
            this.StackTrace = stackTrace;
            this.ExceptionHandled = exceptionHandled;
            this.TopmostContext = topmostContext;
            this.PlCrashReportFileBase64 = plCrashReportFileBase64;
            this.IosImageBaseAddress = iosImageBaseAddress;
            this.IosImageSize = iosImageSize;
            this.SessionNumber = sessionNumber;
        }
        
        /// <summary>
        /// Gets or Sets TimestampUnixtimeMs
        /// </summary>
        [DataMember(Name="timestamp_unixtime_ms", EmitDefaultValue=false)]
        public int TimestampUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets EventId
        /// </summary>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public long EventId { get; private set; }

        /// <summary>
        /// Gets or Sets SourceMessageId
        /// </summary>
        [DataMember(Name="source_message_id", EmitDefaultValue=false)]
        public string SourceMessageId { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="session_id", EmitDefaultValue=false)]
        public long SessionId { get; set; }

        /// <summary>
        /// Gets or Sets SessionUuid
        /// </summary>
        [DataMember(Name="session_uuid", EmitDefaultValue=false)]
        public string SessionUuid { get; set; }

        /// <summary>
        /// Gets or Sets SessionStartUnixtimeMs
        /// </summary>
        [DataMember(Name="session_start_unixtime_ms", EmitDefaultValue=false)]
        public int SessionStartUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets EventStartUnixtimeMs
        /// </summary>
        [DataMember(Name="event_start_unixtime_ms", EmitDefaultValue=false)]
        public int EventStartUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets CustomAttributes
        /// </summary>
        [DataMember(Name="custom_attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> CustomAttributes { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public GeoLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets DeviceCurrentState
        /// </summary>
        [DataMember(Name="device_current_state", EmitDefaultValue=false)]
        public DeviceCurrentState DeviceCurrentState { get; set; }

        /// <summary>
        /// Gets or Sets IsGoalDefined
        /// </summary>
        [DataMember(Name="is_goal_defined", EmitDefaultValue=false)]
        public bool IsGoalDefined { get; set; }

        /// <summary>
        /// Gets or Sets LifetimeValueChange
        /// </summary>
        [DataMember(Name="lifetime_value_change", EmitDefaultValue=false)]
        public bool LifetimeValueChange { get; set; }

        /// <summary>
        /// Gets or Sets LifetimeValueAttributeName
        /// </summary>
        [DataMember(Name="lifetime_value_attribute_name", EmitDefaultValue=false)]
        public string LifetimeValueAttributeName { get; set; }

        /// <summary>
        /// Gets or Sets DataConnectionType
        /// </summary>
        [DataMember(Name="data_connection_type", EmitDefaultValue=false)]
        public string DataConnectionType { get; set; }

        /// <summary>
        /// Gets or Sets EventNum
        /// </summary>
        [DataMember(Name="event_num", EmitDefaultValue=false)]
        public int EventNum { get; set; }

        /// <summary>
        /// Gets or Sets ViewController
        /// </summary>
        [DataMember(Name="view_controller", EmitDefaultValue=false)]
        public string ViewController { get; set; }

        /// <summary>
        /// Gets or Sets IsMainThread
        /// </summary>
        [DataMember(Name="is_main_thread", EmitDefaultValue=false)]
        public bool IsMainThread { get; set; }

        /// <summary>
        /// Gets or Sets CanonicalName
        /// </summary>
        [DataMember(Name="canonical_name", EmitDefaultValue=false)]
        public string CanonicalName { get; set; }

        /// <summary>
        /// Gets or Sets EventSystemNotificationInfo
        /// </summary>
        [DataMember(Name="event_system_notification_info", EmitDefaultValue=false)]
        public EventSystemNotificationInfo EventSystemNotificationInfo { get; set; }

        /// <summary>
        /// Gets or Sets Breadcrumbs
        /// </summary>
        [DataMember(Name="breadcrumbs", EmitDefaultValue=false)]
        public Collection<string> Breadcrumbs { get; set; }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name="class_name", EmitDefaultValue=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets StackTrace
        /// </summary>
        [DataMember(Name="stack_trace", EmitDefaultValue=false)]
        public string StackTrace { get; set; }

        /// <summary>
        /// Gets or Sets ExceptionHandled
        /// </summary>
        [DataMember(Name="exception_handled", EmitDefaultValue=false)]
        public bool ExceptionHandled { get; set; }

        /// <summary>
        /// Gets or Sets TopmostContext
        /// </summary>
        [DataMember(Name="topmost_context", EmitDefaultValue=false)]
        public string TopmostContext { get; set; }

        /// <summary>
        /// Gets or Sets PlCrashReportFileBase64
        /// </summary>
        [DataMember(Name="pl_crash_report_file_base64", EmitDefaultValue=false)]
        public string PlCrashReportFileBase64 { get; set; }

        /// <summary>
        /// Gets or Sets IosImageBaseAddress
        /// </summary>
        [DataMember(Name="ios_image_base_address", EmitDefaultValue=false)]
        public int IosImageBaseAddress { get; set; }

        /// <summary>
        /// Gets or Sets IosImageSize
        /// </summary>
        [DataMember(Name="ios_image_size", EmitDefaultValue=false)]
        public int IosImageSize { get; set; }

        /// <summary>
        /// Gets or Sets SessionNumber
        /// </summary>
        [DataMember(Name="session_number", EmitDefaultValue=false)]
        public int SessionNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrashReportEventData {\n");
            sb.Append("  TimestampUnixtimeMs: ").Append(TimestampUnixtimeMs).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  SourceMessageId: ").Append(SourceMessageId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  SessionUuid: ").Append(SessionUuid).Append("\n");
            sb.Append("  SessionStartUnixtimeMs: ").Append(SessionStartUnixtimeMs).Append("\n");
            sb.Append("  EventStartUnixtimeMs: ").Append(EventStartUnixtimeMs).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  DeviceCurrentState: ").Append(DeviceCurrentState).Append("\n");
            sb.Append("  IsGoalDefined: ").Append(IsGoalDefined).Append("\n");
            sb.Append("  LifetimeValueChange: ").Append(LifetimeValueChange).Append("\n");
            sb.Append("  LifetimeValueAttributeName: ").Append(LifetimeValueAttributeName).Append("\n");
            sb.Append("  DataConnectionType: ").Append(DataConnectionType).Append("\n");
            sb.Append("  EventNum: ").Append(EventNum).Append("\n");
            sb.Append("  ViewController: ").Append(ViewController).Append("\n");
            sb.Append("  IsMainThread: ").Append(IsMainThread).Append("\n");
            sb.Append("  CanonicalName: ").Append(CanonicalName).Append("\n");
            sb.Append("  EventSystemNotificationInfo: ").Append(EventSystemNotificationInfo).Append("\n");
            sb.Append("  Breadcrumbs: ").Append(Breadcrumbs).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  StackTrace: ").Append(StackTrace).Append("\n");
            sb.Append("  ExceptionHandled: ").Append(ExceptionHandled).Append("\n");
            sb.Append("  TopmostContext: ").Append(TopmostContext).Append("\n");
            sb.Append("  PlCrashReportFileBase64: ").Append(PlCrashReportFileBase64).Append("\n");
            sb.Append("  IosImageBaseAddress: ").Append(IosImageBaseAddress).Append("\n");
            sb.Append("  IosImageSize: ").Append(IosImageSize).Append("\n");
            sb.Append("  SessionNumber: ").Append(SessionNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CrashReportEventData);
        }

        /// <summary>
        /// Returns true if CrashReportEventData instances are equal
        /// </summary>
        /// <param name="input">Instance of CrashReportEventData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrashReportEventData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimestampUnixtimeMs == input.TimestampUnixtimeMs ||
                    this.TimestampUnixtimeMs.Equals(input.TimestampUnixtimeMs)
                ) && 
                (
                    this.EventId == input.EventId ||
                    this.EventId.Equals(input.EventId)
                ) && 
                (
                    this.SourceMessageId == input.SourceMessageId ||
                    (this.SourceMessageId != null &&
                    this.SourceMessageId.Equals(input.SourceMessageId))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    this.SessionId.Equals(input.SessionId)
                ) && 
                (
                    this.SessionUuid == input.SessionUuid ||
                    (this.SessionUuid != null &&
                    this.SessionUuid.Equals(input.SessionUuid))
                ) && 
                (
                    this.SessionStartUnixtimeMs == input.SessionStartUnixtimeMs ||
                    this.SessionStartUnixtimeMs.Equals(input.SessionStartUnixtimeMs)
                ) && 
                (
                    this.EventStartUnixtimeMs == input.EventStartUnixtimeMs ||
                    this.EventStartUnixtimeMs.Equals(input.EventStartUnixtimeMs)
                ) && 
                (
                    this.CustomAttributes == input.CustomAttributes ||
                    this.CustomAttributes != null &&
                    input.CustomAttributes != null &&
                    this.CustomAttributes.SequenceEqual(input.CustomAttributes)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.DeviceCurrentState == input.DeviceCurrentState ||
                    (this.DeviceCurrentState != null &&
                    this.DeviceCurrentState.Equals(input.DeviceCurrentState))
                ) && 
                (
                    this.IsGoalDefined == input.IsGoalDefined ||
                    this.IsGoalDefined.Equals(input.IsGoalDefined)
                ) && 
                (
                    this.LifetimeValueChange == input.LifetimeValueChange ||
                    this.LifetimeValueChange.Equals(input.LifetimeValueChange)
                ) && 
                (
                    this.LifetimeValueAttributeName == input.LifetimeValueAttributeName ||
                    (this.LifetimeValueAttributeName != null &&
                    this.LifetimeValueAttributeName.Equals(input.LifetimeValueAttributeName))
                ) && 
                (
                    this.DataConnectionType == input.DataConnectionType ||
                    (this.DataConnectionType != null &&
                    this.DataConnectionType.Equals(input.DataConnectionType))
                ) && 
                (
                    this.EventNum == input.EventNum ||
                    this.EventNum.Equals(input.EventNum)
                ) && 
                (
                    this.ViewController == input.ViewController ||
                    (this.ViewController != null &&
                    this.ViewController.Equals(input.ViewController))
                ) && 
                (
                    this.IsMainThread == input.IsMainThread ||
                    this.IsMainThread.Equals(input.IsMainThread)
                ) && 
                (
                    this.CanonicalName == input.CanonicalName ||
                    (this.CanonicalName != null &&
                    this.CanonicalName.Equals(input.CanonicalName))
                ) && 
                (
                    this.EventSystemNotificationInfo == input.EventSystemNotificationInfo ||
                    (this.EventSystemNotificationInfo != null &&
                    this.EventSystemNotificationInfo.Equals(input.EventSystemNotificationInfo))
                ) && 
                (
                    this.Breadcrumbs == input.Breadcrumbs ||
                    this.Breadcrumbs != null &&
                    input.Breadcrumbs != null &&
                    this.Breadcrumbs.SequenceEqual(input.Breadcrumbs)
                ) && 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.StackTrace == input.StackTrace ||
                    (this.StackTrace != null &&
                    this.StackTrace.Equals(input.StackTrace))
                ) && 
                (
                    this.ExceptionHandled == input.ExceptionHandled ||
                    this.ExceptionHandled.Equals(input.ExceptionHandled)
                ) && 
                (
                    this.TopmostContext == input.TopmostContext ||
                    (this.TopmostContext != null &&
                    this.TopmostContext.Equals(input.TopmostContext))
                ) && 
                (
                    this.PlCrashReportFileBase64 == input.PlCrashReportFileBase64 ||
                    (this.PlCrashReportFileBase64 != null &&
                    this.PlCrashReportFileBase64.Equals(input.PlCrashReportFileBase64))
                ) && 
                (
                    this.IosImageBaseAddress == input.IosImageBaseAddress ||
                    this.IosImageBaseAddress.Equals(input.IosImageBaseAddress)
                ) && 
                (
                    this.IosImageSize == input.IosImageSize ||
                    this.IosImageSize.Equals(input.IosImageSize)
                ) && 
                (
                    this.SessionNumber == input.SessionNumber ||
                    this.SessionNumber.Equals(input.SessionNumber)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.TimestampUnixtimeMs.GetHashCode();
                hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.SourceMessageId != null)
                    hashCode = hashCode * 59 + this.SourceMessageId.GetHashCode();
                hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.SessionUuid != null)
                    hashCode = hashCode * 59 + this.SessionUuid.GetHashCode();
                hashCode = hashCode * 59 + this.SessionStartUnixtimeMs.GetHashCode();
                hashCode = hashCode * 59 + this.EventStartUnixtimeMs.GetHashCode();
                if (this.CustomAttributes != null)
                    hashCode = hashCode * 59 + this.CustomAttributes.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.DeviceCurrentState != null)
                    hashCode = hashCode * 59 + this.DeviceCurrentState.GetHashCode();
                hashCode = hashCode * 59 + this.IsGoalDefined.GetHashCode();
                hashCode = hashCode * 59 + this.LifetimeValueChange.GetHashCode();
                if (this.LifetimeValueAttributeName != null)
                    hashCode = hashCode * 59 + this.LifetimeValueAttributeName.GetHashCode();
                if (this.DataConnectionType != null)
                    hashCode = hashCode * 59 + this.DataConnectionType.GetHashCode();
                hashCode = hashCode * 59 + this.EventNum.GetHashCode();
                if (this.ViewController != null)
                    hashCode = hashCode * 59 + this.ViewController.GetHashCode();
                hashCode = hashCode * 59 + this.IsMainThread.GetHashCode();
                if (this.CanonicalName != null)
                    hashCode = hashCode * 59 + this.CanonicalName.GetHashCode();
                if (this.EventSystemNotificationInfo != null)
                    hashCode = hashCode * 59 + this.EventSystemNotificationInfo.GetHashCode();
                if (this.Breadcrumbs != null)
                    hashCode = hashCode * 59 + this.Breadcrumbs.GetHashCode();
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.StackTrace != null)
                    hashCode = hashCode * 59 + this.StackTrace.GetHashCode();
                hashCode = hashCode * 59 + this.ExceptionHandled.GetHashCode();
                if (this.TopmostContext != null)
                    hashCode = hashCode * 59 + this.TopmostContext.GetHashCode();
                if (this.PlCrashReportFileBase64 != null)
                    hashCode = hashCode * 59 + this.PlCrashReportFileBase64.GetHashCode();
                hashCode = hashCode * 59 + this.IosImageBaseAddress.GetHashCode();
                hashCode = hashCode * 59 + this.IosImageSize.GetHashCode();
                hashCode = hashCode * 59 + this.SessionNumber.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
