/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using ;

namespace FooFlt
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the ApeType_MyMethod Method.
        /// </summary>
        public const uint ApeType_MyMethod = 15054;

        /// <summary>
        /// The identifier for the Ape_MyMethod Method.
        /// </summary>
        public const uint Ape_MyMethod = 15164;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the ApeType_Info Object.
        /// </summary>
        public const uint ApeType_Info = 15002;

        /// <summary>
        /// The identifier for the ApeType_Info_Location Object.
        /// </summary>
        public const uint ApeType_Info_Location = 15007;

        /// <summary>
        /// The identifier for the ApeType_Time Object.
        /// </summary>
        public const uint ApeType_Time = 15010;

        /// <summary>
        /// The identifier for the ApeType_Time_Settings Object.
        /// </summary>
        public const uint ApeType_Time_Settings = 15011;

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_SNTPServer Object.
        /// </summary>
        public const uint ApeType_Time_Settings_SNTPServer = 15016;

        /// <summary>
        /// The identifier for the ApeType_Communication Object.
        /// </summary>
        public const uint ApeType_Communication = 15020;

        /// <summary>
        /// The identifier for the ApeType_Communication_EthernetInterface Object.
        /// </summary>
        public const uint ApeType_Communication_EthernetInterface = 15021;

        /// <summary>
        /// The identifier for the ApeType_Communication_USB Object.
        /// </summary>
        public const uint ApeType_Communication_USB = 15022;

        /// <summary>
        /// The identifier for the ApeType_ZebraSystem Object.
        /// </summary>
        public const uint ApeType_ZebraSystem = 15023;

        /// <summary>
        /// The identifier for the ApeType_ZebraSystem_Configuration Object.
        /// </summary>
        public const uint ApeType_ZebraSystem_Configuration = 15024;

        /// <summary>
        /// The identifier for the ApeType_ZebraSystem_Measurement Object.
        /// </summary>
        public const uint ApeType_ZebraSystem_Measurement = 15025;

        /// <summary>
        /// The identifier for the ApeType_IO Object.
        /// </summary>
        public const uint ApeType_IO = 15026;

        /// <summary>
        /// The identifier for the ApeType_IO_Configuration Object.
        /// </summary>
        public const uint ApeType_IO_Configuration = 15027;

        /// <summary>
        /// The identifier for the ApeType_IO_Measurement Object.
        /// </summary>
        public const uint ApeType_IO_Measurement = 15028;

        /// <summary>
        /// The identifier for the InfoType_Location Object.
        /// </summary>
        public const uint InfoType_Location = 15062;

        /// <summary>
        /// The identifier for the TimeType_Settings Object.
        /// </summary>
        public const uint TimeType_Settings = 15069;

        /// <summary>
        /// The identifier for the TimeType_Settings_SNTPServer Object.
        /// </summary>
        public const uint TimeType_Settings_SNTPServer = 15074;

        /// <summary>
        /// The identifier for the TimeSettingsType_SNTPServer Object.
        /// </summary>
        public const uint TimeSettingsType_SNTPServer = 15083;

        /// <summary>
        /// The identifier for the CommunicationType_EthernetInterface Object.
        /// </summary>
        public const uint CommunicationType_EthernetInterface = 15090;

        /// <summary>
        /// The identifier for the CommunicationType_USB Object.
        /// </summary>
        public const uint CommunicationType_USB = 15091;

        /// <summary>
        /// The identifier for the ZebraSystemType_Configuration Object.
        /// </summary>
        public const uint ZebraSystemType_Configuration = 15095;

        /// <summary>
        /// The identifier for the ZebraSystemType_Measurement Object.
        /// </summary>
        public const uint ZebraSystemType_Measurement = 15096;

        /// <summary>
        /// The identifier for the IOType_Configuration Object.
        /// </summary>
        public const uint IOType_Configuration = 15100;

        /// <summary>
        /// The identifier for the IOType_Measurement Object.
        /// </summary>
        public const uint IOType_Measurement = 15101;

        /// <summary>
        /// The identifier for the Ape Object.
        /// </summary>
        public const uint Ape = 15111;

        /// <summary>
        /// The identifier for the Ape_Info Object.
        /// </summary>
        public const uint Ape_Info = 15112;

        /// <summary>
        /// The identifier for the Ape_Info_Location Object.
        /// </summary>
        public const uint Ape_Info_Location = 15117;

        /// <summary>
        /// The identifier for the Ape_Time Object.
        /// </summary>
        public const uint Ape_Time = 15120;

        /// <summary>
        /// The identifier for the Ape_Time_Settings Object.
        /// </summary>
        public const uint Ape_Time_Settings = 15121;

        /// <summary>
        /// The identifier for the Ape_Time_Settings_SNTPServer Object.
        /// </summary>
        public const uint Ape_Time_Settings_SNTPServer = 15126;

        /// <summary>
        /// The identifier for the Ape_Communication Object.
        /// </summary>
        public const uint Ape_Communication = 15130;

        /// <summary>
        /// The identifier for the Ape_Communication_EthernetInterface Object.
        /// </summary>
        public const uint Ape_Communication_EthernetInterface = 15131;

        /// <summary>
        /// The identifier for the Ape_Communication_USB Object.
        /// </summary>
        public const uint Ape_Communication_USB = 15132;

        /// <summary>
        /// The identifier for the Ape_ZebraSystem Object.
        /// </summary>
        public const uint Ape_ZebraSystem = 15133;

        /// <summary>
        /// The identifier for the Ape_ZebraSystem_Configuration Object.
        /// </summary>
        public const uint Ape_ZebraSystem_Configuration = 15134;

        /// <summary>
        /// The identifier for the Ape_ZebraSystem_Measurement Object.
        /// </summary>
        public const uint Ape_ZebraSystem_Measurement = 15135;

        /// <summary>
        /// The identifier for the Ape_IO Object.
        /// </summary>
        public const uint Ape_IO = 15136;

        /// <summary>
        /// The identifier for the Ape_IO_Configuration Object.
        /// </summary>
        public const uint Ape_IO_Configuration = 15137;

        /// <summary>
        /// The identifier for the Ape_IO_Measurement Object.
        /// </summary>
        public const uint Ape_IO_Measurement = 15138;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the ApeType ObjectType.
        /// </summary>
        public const uint ApeType = 15001;

        /// <summary>
        /// The identifier for the InfoType ObjectType.
        /// </summary>
        public const uint InfoType = 15057;

        /// <summary>
        /// The identifier for the LocationType ObjectType.
        /// </summary>
        public const uint LocationType = 15065;

        /// <summary>
        /// The identifier for the TimeType ObjectType.
        /// </summary>
        public const uint TimeType = 15068;

        /// <summary>
        /// The identifier for the TimeSettingsType ObjectType.
        /// </summary>
        public const uint TimeSettingsType = 15078;

        /// <summary>
        /// The identifier for the SNTPServerType ObjectType.
        /// </summary>
        public const uint SNTPServerType = 15086;

        /// <summary>
        /// The identifier for the CommunicationType ObjectType.
        /// </summary>
        public const uint CommunicationType = 15089;

        /// <summary>
        /// The identifier for the EthernetInterfaceType ObjectType.
        /// </summary>
        public const uint EthernetInterfaceType = 15092;

        /// <summary>
        /// The identifier for the USBType ObjectType.
        /// </summary>
        public const uint USBType = 15093;

        /// <summary>
        /// The identifier for the ZebraSystemType ObjectType.
        /// </summary>
        public const uint ZebraSystemType = 15094;

        /// <summary>
        /// The identifier for the ConfigurationType ObjectType.
        /// </summary>
        public const uint ConfigurationType = 15097;

        /// <summary>
        /// The identifier for the MeasurementType ObjectType.
        /// </summary>
        public const uint MeasurementType = 15098;

        /// <summary>
        /// The identifier for the IOType ObjectType.
        /// </summary>
        public const uint IOType = 15099;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the ApeType_Info_Name Variable.
        /// </summary>
        public const uint ApeType_Info_Name = 15003;

        /// <summary>
        /// The identifier for the ApeType_Info_Type Variable.
        /// </summary>
        public const uint ApeType_Info_Type = 15004;

        /// <summary>
        /// The identifier for the ApeType_Info_SWRelease Variable.
        /// </summary>
        public const uint ApeType_Info_SWRelease = 15005;

        /// <summary>
        /// The identifier for the ApeType_Info_SerialNumber Variable.
        /// </summary>
        public const uint ApeType_Info_SerialNumber = 15006;

        /// <summary>
        /// The identifier for the ApeType_Info_Location_Plant Variable.
        /// </summary>
        public const uint ApeType_Info_Location_Plant = 15008;

        /// <summary>
        /// The identifier for the ApeType_Info_Location_Unit Variable.
        /// </summary>
        public const uint ApeType_Info_Location_Unit = 15009;

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_Date Variable.
        /// </summary>
        public const uint ApeType_Time_Settings_Date = 15012;

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_Time Variable.
        /// </summary>
        public const uint ApeType_Time_Settings_Time = 15013;

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_TimeZone Variable.
        /// </summary>
        public const uint ApeType_Time_Settings_TimeZone = 15014;

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_Source Variable.
        /// </summary>
        public const uint ApeType_Time_Settings_Source = 15015;

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_SNTPServer_Enabled Variable.
        /// </summary>
        public const uint ApeType_Time_Settings_SNTPServer_Enabled = 15017;

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_SNTPServer_IPAddress Variable.
        /// </summary>
        public const uint ApeType_Time_Settings_SNTPServer_IPAddress = 15018;

        /// <summary>
        /// The identifier for the ApeType_Time_ActualTime Variable.
        /// </summary>
        public const uint ApeType_Time_ActualTime = 15019;

        /// <summary>
        /// The identifier for the ApeType_MyVariable Variable.
        /// </summary>
        public const uint ApeType_MyVariable = 15029;

        /// <summary>
        /// The identifier for the ApeType_MyVariable_EURange Variable.
        /// </summary>
        public const uint ApeType_MyVariable_EURange = 15033;

        /// <summary>
        /// The identifier for the ApeType_MyVariable2 Variable.
        /// </summary>
        public const uint ApeType_MyVariable2 = 15035;

        /// <summary>
        /// The identifier for the ApeType_MyVariable2_EURange Variable.
        /// </summary>
        public const uint ApeType_MyVariable2_EURange = 15039;

        /// <summary>
        /// The identifier for the ApeType_MyVariable3 Variable.
        /// </summary>
        public const uint ApeType_MyVariable3 = 15041;

        /// <summary>
        /// The identifier for the ApeType_MyVariable3_EURange Variable.
        /// </summary>
        public const uint ApeType_MyVariable3_EURange = 15045;

        /// <summary>
        /// The identifier for the ApeType_MyVariable3_EngineeringUnits Variable.
        /// </summary>
        public const uint ApeType_MyVariable3_EngineeringUnits = 15046;

        /// <summary>
        /// The identifier for the ApeType_MyVariable4 Variable.
        /// </summary>
        public const uint ApeType_MyVariable4 = 15047;

        /// <summary>
        /// The identifier for the ApeType_MyVariable4_EngineeringUnits Variable.
        /// </summary>
        public const uint ApeType_MyVariable4_EngineeringUnits = 15052;

        /// <summary>
        /// The identifier for the ApeType_dummyToBeRemoved Variable.
        /// </summary>
        public const uint ApeType_dummyToBeRemoved = 15053;

        /// <summary>
        /// The identifier for the ApeType_MyMethod_InputArguments Variable.
        /// </summary>
        public const uint ApeType_MyMethod_InputArguments = 15055;

        /// <summary>
        /// The identifier for the ApeType_MyMethod_OutputArguments Variable.
        /// </summary>
        public const uint ApeType_MyMethod_OutputArguments = 15056;

        /// <summary>
        /// The identifier for the InfoType_Name Variable.
        /// </summary>
        public const uint InfoType_Name = 15058;

        /// <summary>
        /// The identifier for the InfoType_Type Variable.
        /// </summary>
        public const uint InfoType_Type = 15059;

        /// <summary>
        /// The identifier for the InfoType_SWRelease Variable.
        /// </summary>
        public const uint InfoType_SWRelease = 15060;

        /// <summary>
        /// The identifier for the InfoType_SerialNumber Variable.
        /// </summary>
        public const uint InfoType_SerialNumber = 15061;

        /// <summary>
        /// The identifier for the InfoType_Location_Plant Variable.
        /// </summary>
        public const uint InfoType_Location_Plant = 15063;

        /// <summary>
        /// The identifier for the InfoType_Location_Unit Variable.
        /// </summary>
        public const uint InfoType_Location_Unit = 15064;

        /// <summary>
        /// The identifier for the LocationType_Plant Variable.
        /// </summary>
        public const uint LocationType_Plant = 15066;

        /// <summary>
        /// The identifier for the LocationType_Unit Variable.
        /// </summary>
        public const uint LocationType_Unit = 15067;

        /// <summary>
        /// The identifier for the TimeType_Settings_Date Variable.
        /// </summary>
        public const uint TimeType_Settings_Date = 15070;

        /// <summary>
        /// The identifier for the TimeType_Settings_Time Variable.
        /// </summary>
        public const uint TimeType_Settings_Time = 15071;

        /// <summary>
        /// The identifier for the TimeType_Settings_TimeZone Variable.
        /// </summary>
        public const uint TimeType_Settings_TimeZone = 15072;

        /// <summary>
        /// The identifier for the TimeType_Settings_Source Variable.
        /// </summary>
        public const uint TimeType_Settings_Source = 15073;

        /// <summary>
        /// The identifier for the TimeType_Settings_SNTPServer_Enabled Variable.
        /// </summary>
        public const uint TimeType_Settings_SNTPServer_Enabled = 15075;

        /// <summary>
        /// The identifier for the TimeType_Settings_SNTPServer_IPAddress Variable.
        /// </summary>
        public const uint TimeType_Settings_SNTPServer_IPAddress = 15076;

        /// <summary>
        /// The identifier for the TimeType_ActualTime Variable.
        /// </summary>
        public const uint TimeType_ActualTime = 15077;

        /// <summary>
        /// The identifier for the TimeSettingsType_Date Variable.
        /// </summary>
        public const uint TimeSettingsType_Date = 15079;

        /// <summary>
        /// The identifier for the TimeSettingsType_Time Variable.
        /// </summary>
        public const uint TimeSettingsType_Time = 15080;

        /// <summary>
        /// The identifier for the TimeSettingsType_TimeZone Variable.
        /// </summary>
        public const uint TimeSettingsType_TimeZone = 15081;

        /// <summary>
        /// The identifier for the TimeSettingsType_Source Variable.
        /// </summary>
        public const uint TimeSettingsType_Source = 15082;

        /// <summary>
        /// The identifier for the TimeSettingsType_SNTPServer_Enabled Variable.
        /// </summary>
        public const uint TimeSettingsType_SNTPServer_Enabled = 15084;

        /// <summary>
        /// The identifier for the TimeSettingsType_SNTPServer_IPAddress Variable.
        /// </summary>
        public const uint TimeSettingsType_SNTPServer_IPAddress = 15085;

        /// <summary>
        /// The identifier for the SNTPServerType_Enabled Variable.
        /// </summary>
        public const uint SNTPServerType_Enabled = 15087;

        /// <summary>
        /// The identifier for the SNTPServerType_IPAddress Variable.
        /// </summary>
        public const uint SNTPServerType_IPAddress = 15088;

        /// <summary>
        /// The identifier for the Ape_Info_Name Variable.
        /// </summary>
        public const uint Ape_Info_Name = 15113;

        /// <summary>
        /// The identifier for the Ape_Info_Type Variable.
        /// </summary>
        public const uint Ape_Info_Type = 15114;

        /// <summary>
        /// The identifier for the Ape_Info_SWRelease Variable.
        /// </summary>
        public const uint Ape_Info_SWRelease = 15115;

        /// <summary>
        /// The identifier for the Ape_Info_SerialNumber Variable.
        /// </summary>
        public const uint Ape_Info_SerialNumber = 15116;

        /// <summary>
        /// The identifier for the Ape_Info_Location_Plant Variable.
        /// </summary>
        public const uint Ape_Info_Location_Plant = 15118;

        /// <summary>
        /// The identifier for the Ape_Info_Location_Unit Variable.
        /// </summary>
        public const uint Ape_Info_Location_Unit = 15119;

        /// <summary>
        /// The identifier for the Ape_Time_Settings_Date Variable.
        /// </summary>
        public const uint Ape_Time_Settings_Date = 15122;

        /// <summary>
        /// The identifier for the Ape_Time_Settings_Time Variable.
        /// </summary>
        public const uint Ape_Time_Settings_Time = 15123;

        /// <summary>
        /// The identifier for the Ape_Time_Settings_TimeZone Variable.
        /// </summary>
        public const uint Ape_Time_Settings_TimeZone = 15124;

        /// <summary>
        /// The identifier for the Ape_Time_Settings_Source Variable.
        /// </summary>
        public const uint Ape_Time_Settings_Source = 15125;

        /// <summary>
        /// The identifier for the Ape_Time_Settings_SNTPServer_Enabled Variable.
        /// </summary>
        public const uint Ape_Time_Settings_SNTPServer_Enabled = 15127;

        /// <summary>
        /// The identifier for the Ape_Time_Settings_SNTPServer_IPAddress Variable.
        /// </summary>
        public const uint Ape_Time_Settings_SNTPServer_IPAddress = 15128;

        /// <summary>
        /// The identifier for the Ape_Time_ActualTime Variable.
        /// </summary>
        public const uint Ape_Time_ActualTime = 15129;

        /// <summary>
        /// The identifier for the Ape_MyVariable Variable.
        /// </summary>
        public const uint Ape_MyVariable = 15139;

        /// <summary>
        /// The identifier for the Ape_MyVariable_EURange Variable.
        /// </summary>
        public const uint Ape_MyVariable_EURange = 15143;

        /// <summary>
        /// The identifier for the Ape_MyVariable2 Variable.
        /// </summary>
        public const uint Ape_MyVariable2 = 15145;

        /// <summary>
        /// The identifier for the Ape_MyVariable2_EURange Variable.
        /// </summary>
        public const uint Ape_MyVariable2_EURange = 15149;

        /// <summary>
        /// The identifier for the Ape_MyVariable3 Variable.
        /// </summary>
        public const uint Ape_MyVariable3 = 15151;

        /// <summary>
        /// The identifier for the Ape_MyVariable3_EURange Variable.
        /// </summary>
        public const uint Ape_MyVariable3_EURange = 15155;

        /// <summary>
        /// The identifier for the Ape_MyVariable3_EngineeringUnits Variable.
        /// </summary>
        public const uint Ape_MyVariable3_EngineeringUnits = 15156;

        /// <summary>
        /// The identifier for the Ape_MyVariable4 Variable.
        /// </summary>
        public const uint Ape_MyVariable4 = 15157;

        /// <summary>
        /// The identifier for the Ape_MyVariable4_EngineeringUnits Variable.
        /// </summary>
        public const uint Ape_MyVariable4_EngineeringUnits = 15162;

        /// <summary>
        /// The identifier for the Ape_dummyToBeRemoved Variable.
        /// </summary>
        public const uint Ape_dummyToBeRemoved = 15163;

        /// <summary>
        /// The identifier for the Ape_MyMethod_InputArguments Variable.
        /// </summary>
        public const uint Ape_MyMethod_InputArguments = 15165;

        /// <summary>
        /// The identifier for the Ape_MyMethod_OutputArguments Variable.
        /// </summary>
        public const uint Ape_MyMethod_OutputArguments = 15166;
    }
    #endregion

    #region VariableType Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <summary>
        /// The identifier for the FooAnalogItemType VariableType.
        /// </summary>
        public const uint FooAnalogItemType = 15102;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the ApeType_MyMethod Method.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_MyMethod = new ExpandedNodeId(FooFlt.Methods.ApeType_MyMethod, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_MyMethod Method.
        /// </summary>
        public static readonly ExpandedNodeId Ape_MyMethod = new ExpandedNodeId(FooFlt.Methods.Ape_MyMethod, FooFlt.Namespaces.FooZbrFlt);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the ApeType_Info Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Info = new ExpandedNodeId(FooFlt.Objects.ApeType_Info, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Info_Location Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Info_Location = new ExpandedNodeId(FooFlt.Objects.ApeType_Info_Location, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Time Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Time = new ExpandedNodeId(FooFlt.Objects.ApeType_Time, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Time_Settings Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Time_Settings = new ExpandedNodeId(FooFlt.Objects.ApeType_Time_Settings, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_SNTPServer Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Time_Settings_SNTPServer = new ExpandedNodeId(FooFlt.Objects.ApeType_Time_Settings_SNTPServer, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Communication Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Communication = new ExpandedNodeId(FooFlt.Objects.ApeType_Communication, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Communication_EthernetInterface Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Communication_EthernetInterface = new ExpandedNodeId(FooFlt.Objects.ApeType_Communication_EthernetInterface, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Communication_USB Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Communication_USB = new ExpandedNodeId(FooFlt.Objects.ApeType_Communication_USB, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_ZebraSystem Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_ZebraSystem = new ExpandedNodeId(FooFlt.Objects.ApeType_ZebraSystem, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_ZebraSystem_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_ZebraSystem_Configuration = new ExpandedNodeId(FooFlt.Objects.ApeType_ZebraSystem_Configuration, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_ZebraSystem_Measurement Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_ZebraSystem_Measurement = new ExpandedNodeId(FooFlt.Objects.ApeType_ZebraSystem_Measurement, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_IO Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_IO = new ExpandedNodeId(FooFlt.Objects.ApeType_IO, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_IO_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_IO_Configuration = new ExpandedNodeId(FooFlt.Objects.ApeType_IO_Configuration, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_IO_Measurement Object.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_IO_Measurement = new ExpandedNodeId(FooFlt.Objects.ApeType_IO_Measurement, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the InfoType_Location Object.
        /// </summary>
        public static readonly ExpandedNodeId InfoType_Location = new ExpandedNodeId(FooFlt.Objects.InfoType_Location, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeType_Settings Object.
        /// </summary>
        public static readonly ExpandedNodeId TimeType_Settings = new ExpandedNodeId(FooFlt.Objects.TimeType_Settings, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeType_Settings_SNTPServer Object.
        /// </summary>
        public static readonly ExpandedNodeId TimeType_Settings_SNTPServer = new ExpandedNodeId(FooFlt.Objects.TimeType_Settings_SNTPServer, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeSettingsType_SNTPServer Object.
        /// </summary>
        public static readonly ExpandedNodeId TimeSettingsType_SNTPServer = new ExpandedNodeId(FooFlt.Objects.TimeSettingsType_SNTPServer, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the CommunicationType_EthernetInterface Object.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationType_EthernetInterface = new ExpandedNodeId(FooFlt.Objects.CommunicationType_EthernetInterface, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the CommunicationType_USB Object.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationType_USB = new ExpandedNodeId(FooFlt.Objects.CommunicationType_USB, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ZebraSystemType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId ZebraSystemType_Configuration = new ExpandedNodeId(FooFlt.Objects.ZebraSystemType_Configuration, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ZebraSystemType_Measurement Object.
        /// </summary>
        public static readonly ExpandedNodeId ZebraSystemType_Measurement = new ExpandedNodeId(FooFlt.Objects.ZebraSystemType_Measurement, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the IOType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId IOType_Configuration = new ExpandedNodeId(FooFlt.Objects.IOType_Configuration, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the IOType_Measurement Object.
        /// </summary>
        public static readonly ExpandedNodeId IOType_Measurement = new ExpandedNodeId(FooFlt.Objects.IOType_Measurement, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape = new ExpandedNodeId(FooFlt.Objects.Ape, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Info Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Info = new ExpandedNodeId(FooFlt.Objects.Ape_Info, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Info_Location Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Info_Location = new ExpandedNodeId(FooFlt.Objects.Ape_Info_Location, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Time Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Time = new ExpandedNodeId(FooFlt.Objects.Ape_Time, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Time_Settings Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Time_Settings = new ExpandedNodeId(FooFlt.Objects.Ape_Time_Settings, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Time_Settings_SNTPServer Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Time_Settings_SNTPServer = new ExpandedNodeId(FooFlt.Objects.Ape_Time_Settings_SNTPServer, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Communication Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Communication = new ExpandedNodeId(FooFlt.Objects.Ape_Communication, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Communication_EthernetInterface Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Communication_EthernetInterface = new ExpandedNodeId(FooFlt.Objects.Ape_Communication_EthernetInterface, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Communication_USB Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Communication_USB = new ExpandedNodeId(FooFlt.Objects.Ape_Communication_USB, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_ZebraSystem Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_ZebraSystem = new ExpandedNodeId(FooFlt.Objects.Ape_ZebraSystem, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_ZebraSystem_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_ZebraSystem_Configuration = new ExpandedNodeId(FooFlt.Objects.Ape_ZebraSystem_Configuration, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_ZebraSystem_Measurement Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_ZebraSystem_Measurement = new ExpandedNodeId(FooFlt.Objects.Ape_ZebraSystem_Measurement, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_IO Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_IO = new ExpandedNodeId(FooFlt.Objects.Ape_IO, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_IO_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_IO_Configuration = new ExpandedNodeId(FooFlt.Objects.Ape_IO_Configuration, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_IO_Measurement Object.
        /// </summary>
        public static readonly ExpandedNodeId Ape_IO_Measurement = new ExpandedNodeId(FooFlt.Objects.Ape_IO_Measurement, FooFlt.Namespaces.FooZbrFlt);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the ApeType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ApeType = new ExpandedNodeId(FooFlt.ObjectTypes.ApeType, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the InfoType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId InfoType = new ExpandedNodeId(FooFlt.ObjectTypes.InfoType, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the LocationType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LocationType = new ExpandedNodeId(FooFlt.ObjectTypes.LocationType, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TimeType = new ExpandedNodeId(FooFlt.ObjectTypes.TimeType, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeSettingsType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TimeSettingsType = new ExpandedNodeId(FooFlt.ObjectTypes.TimeSettingsType, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the SNTPServerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SNTPServerType = new ExpandedNodeId(FooFlt.ObjectTypes.SNTPServerType, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the CommunicationType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationType = new ExpandedNodeId(FooFlt.ObjectTypes.CommunicationType, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the EthernetInterfaceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId EthernetInterfaceType = new ExpandedNodeId(FooFlt.ObjectTypes.EthernetInterfaceType, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the USBType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId USBType = new ExpandedNodeId(FooFlt.ObjectTypes.USBType, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ZebraSystemType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ZebraSystemType = new ExpandedNodeId(FooFlt.ObjectTypes.ZebraSystemType, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ConfigurationType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConfigurationType = new ExpandedNodeId(FooFlt.ObjectTypes.ConfigurationType, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the MeasurementType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MeasurementType = new ExpandedNodeId(FooFlt.ObjectTypes.MeasurementType, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the IOType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId IOType = new ExpandedNodeId(FooFlt.ObjectTypes.IOType, FooFlt.Namespaces.FooZbrFlt);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the ApeType_Info_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Info_Name = new ExpandedNodeId(FooFlt.Variables.ApeType_Info_Name, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Info_Type Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Info_Type = new ExpandedNodeId(FooFlt.Variables.ApeType_Info_Type, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Info_SWRelease Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Info_SWRelease = new ExpandedNodeId(FooFlt.Variables.ApeType_Info_SWRelease, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Info_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Info_SerialNumber = new ExpandedNodeId(FooFlt.Variables.ApeType_Info_SerialNumber, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Info_Location_Plant Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Info_Location_Plant = new ExpandedNodeId(FooFlt.Variables.ApeType_Info_Location_Plant, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Info_Location_Unit Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Info_Location_Unit = new ExpandedNodeId(FooFlt.Variables.ApeType_Info_Location_Unit, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_Date Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Time_Settings_Date = new ExpandedNodeId(FooFlt.Variables.ApeType_Time_Settings_Date, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Time_Settings_Time = new ExpandedNodeId(FooFlt.Variables.ApeType_Time_Settings_Time, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_TimeZone Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Time_Settings_TimeZone = new ExpandedNodeId(FooFlt.Variables.ApeType_Time_Settings_TimeZone, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_Source Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Time_Settings_Source = new ExpandedNodeId(FooFlt.Variables.ApeType_Time_Settings_Source, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_SNTPServer_Enabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Time_Settings_SNTPServer_Enabled = new ExpandedNodeId(FooFlt.Variables.ApeType_Time_Settings_SNTPServer_Enabled, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Time_Settings_SNTPServer_IPAddress Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Time_Settings_SNTPServer_IPAddress = new ExpandedNodeId(FooFlt.Variables.ApeType_Time_Settings_SNTPServer_IPAddress, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_Time_ActualTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_Time_ActualTime = new ExpandedNodeId(FooFlt.Variables.ApeType_Time_ActualTime, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_MyVariable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_MyVariable = new ExpandedNodeId(FooFlt.Variables.ApeType_MyVariable, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_MyVariable_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_MyVariable_EURange = new ExpandedNodeId(FooFlt.Variables.ApeType_MyVariable_EURange, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_MyVariable2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_MyVariable2 = new ExpandedNodeId(FooFlt.Variables.ApeType_MyVariable2, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_MyVariable2_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_MyVariable2_EURange = new ExpandedNodeId(FooFlt.Variables.ApeType_MyVariable2_EURange, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_MyVariable3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_MyVariable3 = new ExpandedNodeId(FooFlt.Variables.ApeType_MyVariable3, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_MyVariable3_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_MyVariable3_EURange = new ExpandedNodeId(FooFlt.Variables.ApeType_MyVariable3_EURange, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_MyVariable3_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_MyVariable3_EngineeringUnits = new ExpandedNodeId(FooFlt.Variables.ApeType_MyVariable3_EngineeringUnits, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_MyVariable4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_MyVariable4 = new ExpandedNodeId(FooFlt.Variables.ApeType_MyVariable4, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_MyVariable4_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_MyVariable4_EngineeringUnits = new ExpandedNodeId(FooFlt.Variables.ApeType_MyVariable4_EngineeringUnits, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_dummyToBeRemoved Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_dummyToBeRemoved = new ExpandedNodeId(FooFlt.Variables.ApeType_dummyToBeRemoved, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_MyMethod_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_MyMethod_InputArguments = new ExpandedNodeId(FooFlt.Variables.ApeType_MyMethod_InputArguments, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the ApeType_MyMethod_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ApeType_MyMethod_OutputArguments = new ExpandedNodeId(FooFlt.Variables.ApeType_MyMethod_OutputArguments, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the InfoType_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId InfoType_Name = new ExpandedNodeId(FooFlt.Variables.InfoType_Name, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the InfoType_Type Variable.
        /// </summary>
        public static readonly ExpandedNodeId InfoType_Type = new ExpandedNodeId(FooFlt.Variables.InfoType_Type, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the InfoType_SWRelease Variable.
        /// </summary>
        public static readonly ExpandedNodeId InfoType_SWRelease = new ExpandedNodeId(FooFlt.Variables.InfoType_SWRelease, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the InfoType_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId InfoType_SerialNumber = new ExpandedNodeId(FooFlt.Variables.InfoType_SerialNumber, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the InfoType_Location_Plant Variable.
        /// </summary>
        public static readonly ExpandedNodeId InfoType_Location_Plant = new ExpandedNodeId(FooFlt.Variables.InfoType_Location_Plant, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the InfoType_Location_Unit Variable.
        /// </summary>
        public static readonly ExpandedNodeId InfoType_Location_Unit = new ExpandedNodeId(FooFlt.Variables.InfoType_Location_Unit, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the LocationType_Plant Variable.
        /// </summary>
        public static readonly ExpandedNodeId LocationType_Plant = new ExpandedNodeId(FooFlt.Variables.LocationType_Plant, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the LocationType_Unit Variable.
        /// </summary>
        public static readonly ExpandedNodeId LocationType_Unit = new ExpandedNodeId(FooFlt.Variables.LocationType_Unit, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeType_Settings_Date Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeType_Settings_Date = new ExpandedNodeId(FooFlt.Variables.TimeType_Settings_Date, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeType_Settings_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeType_Settings_Time = new ExpandedNodeId(FooFlt.Variables.TimeType_Settings_Time, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeType_Settings_TimeZone Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeType_Settings_TimeZone = new ExpandedNodeId(FooFlt.Variables.TimeType_Settings_TimeZone, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeType_Settings_Source Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeType_Settings_Source = new ExpandedNodeId(FooFlt.Variables.TimeType_Settings_Source, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeType_Settings_SNTPServer_Enabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeType_Settings_SNTPServer_Enabled = new ExpandedNodeId(FooFlt.Variables.TimeType_Settings_SNTPServer_Enabled, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeType_Settings_SNTPServer_IPAddress Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeType_Settings_SNTPServer_IPAddress = new ExpandedNodeId(FooFlt.Variables.TimeType_Settings_SNTPServer_IPAddress, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeType_ActualTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeType_ActualTime = new ExpandedNodeId(FooFlt.Variables.TimeType_ActualTime, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeSettingsType_Date Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeSettingsType_Date = new ExpandedNodeId(FooFlt.Variables.TimeSettingsType_Date, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeSettingsType_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeSettingsType_Time = new ExpandedNodeId(FooFlt.Variables.TimeSettingsType_Time, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeSettingsType_TimeZone Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeSettingsType_TimeZone = new ExpandedNodeId(FooFlt.Variables.TimeSettingsType_TimeZone, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeSettingsType_Source Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeSettingsType_Source = new ExpandedNodeId(FooFlt.Variables.TimeSettingsType_Source, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeSettingsType_SNTPServer_Enabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeSettingsType_SNTPServer_Enabled = new ExpandedNodeId(FooFlt.Variables.TimeSettingsType_SNTPServer_Enabled, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the TimeSettingsType_SNTPServer_IPAddress Variable.
        /// </summary>
        public static readonly ExpandedNodeId TimeSettingsType_SNTPServer_IPAddress = new ExpandedNodeId(FooFlt.Variables.TimeSettingsType_SNTPServer_IPAddress, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the SNTPServerType_Enabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId SNTPServerType_Enabled = new ExpandedNodeId(FooFlt.Variables.SNTPServerType_Enabled, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the SNTPServerType_IPAddress Variable.
        /// </summary>
        public static readonly ExpandedNodeId SNTPServerType_IPAddress = new ExpandedNodeId(FooFlt.Variables.SNTPServerType_IPAddress, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Info_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Info_Name = new ExpandedNodeId(FooFlt.Variables.Ape_Info_Name, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Info_Type Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Info_Type = new ExpandedNodeId(FooFlt.Variables.Ape_Info_Type, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Info_SWRelease Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Info_SWRelease = new ExpandedNodeId(FooFlt.Variables.Ape_Info_SWRelease, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Info_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Info_SerialNumber = new ExpandedNodeId(FooFlt.Variables.Ape_Info_SerialNumber, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Info_Location_Plant Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Info_Location_Plant = new ExpandedNodeId(FooFlt.Variables.Ape_Info_Location_Plant, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Info_Location_Unit Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Info_Location_Unit = new ExpandedNodeId(FooFlt.Variables.Ape_Info_Location_Unit, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Time_Settings_Date Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Time_Settings_Date = new ExpandedNodeId(FooFlt.Variables.Ape_Time_Settings_Date, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Time_Settings_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Time_Settings_Time = new ExpandedNodeId(FooFlt.Variables.Ape_Time_Settings_Time, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Time_Settings_TimeZone Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Time_Settings_TimeZone = new ExpandedNodeId(FooFlt.Variables.Ape_Time_Settings_TimeZone, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Time_Settings_Source Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Time_Settings_Source = new ExpandedNodeId(FooFlt.Variables.Ape_Time_Settings_Source, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Time_Settings_SNTPServer_Enabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Time_Settings_SNTPServer_Enabled = new ExpandedNodeId(FooFlt.Variables.Ape_Time_Settings_SNTPServer_Enabled, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Time_Settings_SNTPServer_IPAddress Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Time_Settings_SNTPServer_IPAddress = new ExpandedNodeId(FooFlt.Variables.Ape_Time_Settings_SNTPServer_IPAddress, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_Time_ActualTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_Time_ActualTime = new ExpandedNodeId(FooFlt.Variables.Ape_Time_ActualTime, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_MyVariable Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_MyVariable = new ExpandedNodeId(FooFlt.Variables.Ape_MyVariable, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_MyVariable_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_MyVariable_EURange = new ExpandedNodeId(FooFlt.Variables.Ape_MyVariable_EURange, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_MyVariable2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_MyVariable2 = new ExpandedNodeId(FooFlt.Variables.Ape_MyVariable2, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_MyVariable2_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_MyVariable2_EURange = new ExpandedNodeId(FooFlt.Variables.Ape_MyVariable2_EURange, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_MyVariable3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_MyVariable3 = new ExpandedNodeId(FooFlt.Variables.Ape_MyVariable3, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_MyVariable3_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_MyVariable3_EURange = new ExpandedNodeId(FooFlt.Variables.Ape_MyVariable3_EURange, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_MyVariable3_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_MyVariable3_EngineeringUnits = new ExpandedNodeId(FooFlt.Variables.Ape_MyVariable3_EngineeringUnits, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_MyVariable4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_MyVariable4 = new ExpandedNodeId(FooFlt.Variables.Ape_MyVariable4, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_MyVariable4_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_MyVariable4_EngineeringUnits = new ExpandedNodeId(FooFlt.Variables.Ape_MyVariable4_EngineeringUnits, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_dummyToBeRemoved Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_dummyToBeRemoved = new ExpandedNodeId(FooFlt.Variables.Ape_dummyToBeRemoved, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_MyMethod_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_MyMethod_InputArguments = new ExpandedNodeId(FooFlt.Variables.Ape_MyMethod_InputArguments, FooFlt.Namespaces.FooZbrFlt);

        /// <summary>
        /// The identifier for the Ape_MyMethod_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Ape_MyMethod_OutputArguments = new ExpandedNodeId(FooFlt.Variables.Ape_MyMethod_OutputArguments, FooFlt.Namespaces.FooZbrFlt);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <summary>
        /// The identifier for the FooAnalogItemType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId FooAnalogItemType = new ExpandedNodeId(FooFlt.VariableTypes.FooAnalogItemType, FooFlt.Namespaces.FooZbrFlt);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the ActualTime component.
        /// </summary>
        public const string ActualTime = "ActualTime";

        /// <summary>
        /// The BrowseName for the Ape component.
        /// </summary>
        public const string Ape = "Ape";

        /// <summary>
        /// The BrowseName for the ApeType component.
        /// </summary>
        public const string ApeType = "ApeType";

        /// <summary>
        /// The BrowseName for the Communication component.
        /// </summary>
        public const string Communication = "Communication";

        /// <summary>
        /// The BrowseName for the CommunicationType component.
        /// </summary>
        public const string CommunicationType = "CommunicationType";

        /// <summary>
        /// The BrowseName for the Configuration component.
        /// </summary>
        public const string Configuration = "Configuration";

        /// <summary>
        /// The BrowseName for the ConfigurationType component.
        /// </summary>
        public const string ConfigurationType = "ConfigurationType";

        /// <summary>
        /// The BrowseName for the Date component.
        /// </summary>
        public const string Date = "Date";

        /// <summary>
        /// The BrowseName for the dummyToBeRemoved component.
        /// </summary>
        public const string dummyToBeRemoved = "dummyToBeRemoved";

        /// <summary>
        /// The BrowseName for the Enabled component.
        /// </summary>
        public const string Enabled = "Enabled";

        /// <summary>
        /// The BrowseName for the EthernetInterface component.
        /// </summary>
        public const string EthernetInterface = "EthernetInterface";

        /// <summary>
        /// The BrowseName for the EthernetInterfaceType component.
        /// </summary>
        public const string EthernetInterfaceType = "EthernetInterfaceType";

        /// <summary>
        /// The BrowseName for the FooAnalogItemType component.
        /// </summary>
        public const string FooAnalogItemType = "FooAnalogItemType";

        /// <summary>
        /// The BrowseName for the Info component.
        /// </summary>
        public const string Info = "Info";

        /// <summary>
        /// The BrowseName for the InfoType component.
        /// </summary>
        public const string InfoType = "InfoType";

        /// <summary>
        /// The BrowseName for the IO component.
        /// </summary>
        public const string IO = "IO";

        /// <summary>
        /// The BrowseName for the IOType component.
        /// </summary>
        public const string IOType = "IOType";

        /// <summary>
        /// The BrowseName for the IPAddress component.
        /// </summary>
        public const string IPAddress = "IPAddress";

        /// <summary>
        /// The BrowseName for the Location component.
        /// </summary>
        public const string Location = "Location";

        /// <summary>
        /// The BrowseName for the LocationType component.
        /// </summary>
        public const string LocationType = "LocationType";

        /// <summary>
        /// The BrowseName for the Measurement component.
        /// </summary>
        public const string Measurement = "Measurement";

        /// <summary>
        /// The BrowseName for the MeasurementType component.
        /// </summary>
        public const string MeasurementType = "MeasurementType";

        /// <summary>
        /// The BrowseName for the MyMethod component.
        /// </summary>
        public const string MyMethod = "MyMethod";

        /// <summary>
        /// The BrowseName for the MyVariable component.
        /// </summary>
        public const string MyVariable = "MyVariable";

        /// <summary>
        /// The BrowseName for the MyVariable2 component.
        /// </summary>
        public const string MyVariable2 = "MyVariable2";

        /// <summary>
        /// The BrowseName for the MyVariable3 component.
        /// </summary>
        public const string MyVariable3 = "MyVariable3";

        /// <summary>
        /// The BrowseName for the MyVariable4 component.
        /// </summary>
        public const string MyVariable4 = "MyVariable4";

        /// <summary>
        /// The BrowseName for the Name component.
        /// </summary>
        public const string Name = "Name";

        /// <summary>
        /// The BrowseName for the Plant component.
        /// </summary>
        public const string Plant = "Plant";

        /// <summary>
        /// The BrowseName for the SerialNumber component.
        /// </summary>
        public const string SerialNumber = "SerialNumber";

        /// <summary>
        /// The BrowseName for the Settings component.
        /// </summary>
        public const string Settings = "Settings";

        /// <summary>
        /// The BrowseName for the SNTPServer component.
        /// </summary>
        public const string SNTPServer = "SNTPServer";

        /// <summary>
        /// The BrowseName for the SNTPServerType component.
        /// </summary>
        public const string SNTPServerType = "SNTPServerType";

        /// <summary>
        /// The BrowseName for the Source component.
        /// </summary>
        public const string Source = "Source";

        /// <summary>
        /// The BrowseName for the SWRelease component.
        /// </summary>
        public const string SWRelease = "SWRelease";

        /// <summary>
        /// The BrowseName for the Time component.
        /// </summary>
        public const string Time = "Time";

        /// <summary>
        /// The BrowseName for the TimeSettingsType component.
        /// </summary>
        public const string TimeSettingsType = "TimeSettingsType";

        /// <summary>
        /// The BrowseName for the TimeType component.
        /// </summary>
        public const string TimeType = "TimeType";

        /// <summary>
        /// The BrowseName for the TimeZone component.
        /// </summary>
        public const string TimeZone = "TimeZone";

        /// <summary>
        /// The BrowseName for the Type component.
        /// </summary>
        public const string Type = "Type";

        /// <summary>
        /// The BrowseName for the Unit component.
        /// </summary>
        public const string Unit = "Unit";

        /// <summary>
        /// The BrowseName for the USB component.
        /// </summary>
        public const string USB = "USB";

        /// <summary>
        /// The BrowseName for the USBType component.
        /// </summary>
        public const string USBType = "USBType";

        /// <summary>
        /// The BrowseName for the ZebraSystem component.
        /// </summary>
        public const string ZebraSystem = "ZebraSystem";

        /// <summary>
        /// The BrowseName for the ZebraSystemType component.
        /// </summary>
        public const string ZebraSystemType = "ZebraSystemType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the FooZbrFlt namespace (.NET code namespace is 'FooFlt').
        /// </summary>
        public const string FooZbrFlt = "https://new.foo.com/zebra-compression/flattening-and-subspacefolding/UA/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is '').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";
    }
    #endregion
}