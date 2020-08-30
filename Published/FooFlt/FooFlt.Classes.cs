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
using System.Xml;
using System.Runtime.Serialization;
using ;

namespace FooFlt
{
    #region ApeState Class
    #if (!OPCUA_EXCLUDE_ApeState)
    /// <summary>
    /// Stores an instance of the ApeType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ApeState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ApeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.ApeType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABAA8AAABBcGVUeXBlSW5zdGFuY2UBAZk6AQGZ" +
           "Opk6AAD/////CwAAAARggAoBAAAAAQAEAAAASW5mbwEBmjoALwEB0TqaOgAA/////wUAAAAVYIkKAgAA" +
           "AAEABAAAAE5hbWUBAZs6AC4ARJs6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAQAAABUeXBlAQGc" +
           "OgAuAEScOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAJAAAAU1dSZWxlYXNlAQGdOgAuAESdOgAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAQGeOgAuAESeOgAAAAz/////" +
           "AQH/////AAAAAARggAoBAAAAAQAIAAAATG9jYXRpb24BAZ86AC8BAdk6nzoAAP////8CAAAAFWCJCgIA" +
           "AAABAAUAAABQbGFudAEBoDoALgBEoDoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABAAAAFVuaXQB" +
           "AaE6AC4ARKE6AAAADP////8BAf////8AAAAABGCACgEAAAABAAQAAABUaW1lAQGiOgAvAQHcOqI6AAD/" +
           "////AgAAAARggAoBAAAAAQAIAAAAU2V0dGluZ3MBAaM6AC8BAeY6ozoAAP////8FAAAAFWCJCgIAAAAB" +
           "AAQAAABEYXRlAQGkOgAuAESkOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAEAAAAVGltZQEBpToA" +
           "LgBEpToAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAFRpbWVab25lAQGmOgAuAESmOgAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAGAAAAU291cmNlAQGnOgAuAESnOgAAAAz/////AQH/////AAAA" +
           "AARggAoBAAAAAQAKAAAAU05UUFNlcnZlcgEBqDoALwEB7jqoOgAA/////wIAAAAVYIkKAgAAAAEABwAA" +
           "AEVuYWJsZWQBAak6AC4ARKk6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAkAAABJUEFkZHJlc3MB" +
           "Aao6AC4ARKo6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAoAAABBY3R1YWxUaW1lAQGrOgAuAESr" +
           "OgAAAAz/////AQH/////AAAAAARggAoBAAAAAQANAAAAQ29tbXVuaWNhdGlvbgEBrDoALwEB8TqsOgAA" +
           "/////wIAAAAEYIAKAQAAAAEAEQAAAEV0aGVybmV0SW50ZXJmYWNlAQGtOgAvAQH0Oq06AAD/////AAAA" +
           "AARggAoBAAAAAQADAAAAVVNCAQGuOgAvAQH1Oq46AAD/////AAAAAARggAoBAAAAAQALAAAAWmVicmFT" +
           "eXN0ZW0BAa86AC8BAfY6rzoAAP////8CAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9uAQGwOgAv" +
           "AQH5OrA6AAD/////AAAAAARggAoBAAAAAQALAAAATWVhc3VyZW1lbnQBAbE6AC8BAfo6sToAAP////8A" +
           "AAAABGCACgEAAAABAAIAAABJTwEBsjoALwEB+zqyOgAA/////wIAAAAEYIAKAQAAAAEADQAAAENvbmZp" +
           "Z3VyYXRpb24BAbM6AC8BAfk6szoAAP////8AAAAABGCACgEAAAABAAsAAABNZWFzdXJlbWVudAEBtDoA" +
           "LwEB+jq0OgAA/////wAAAAAVYIkKAgAAAAEACgAAAE15VmFyaWFibGUBAbU6AC8BAEAJtToAAAAL////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAbk6AC4ARLk6AAABAHQD/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEACwAAAE15VmFyaWFibGUyAQG7OgAvAQH+Ors6AAAAGv////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQG/OgAuAES/OgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABNeVZhcmlhYmxlMwEBwToALwEAokTBOgAAABr/////AQH/////AgAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQEBxToALgBExToAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAAAQAAAARW5naW5lZXJpbmdV" +
           "bml0cwEBxjoALgBExjoAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQALAAAATXlWYXJpYWJsZTQB" +
           "Acc6AC8BAFlExzoAAAAa/////wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMB" +
           "Acw6AC4ARMw6AAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAGR1bW15VG9CZVJlbW92ZWQB" +
           "Ac06AC4ARM06AAABAHcD/////wEB/////wAAAAAEYYIKBAAAAAEACAAAAE15TWV0aG9kAQHOOgAvAQHO" +
           "Os46AAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBzzoALgBEzzoAAJYCAAAA" +
           "AQAqAQEZAAAACgAAAEFjdGlvbk5hbWUADP////8AAAAAAAEAKgEBGQAAAAoAAABNZXRob2ROYW1lAAz/" +
           "////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1l" +
           "bnRzAQHQOgAuAETQOgAAlgEAAAABACoBARUAAAAGAAAAUmVzdWx0AAb/////AAAAAAABACgBAQAAAAEA" +
           "AAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public InfoState Info
        {
            get
            {
                return m_info;
            }

            set
            {
                if (!Object.ReferenceEquals(m_info, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_info = value;
            }
        }

        /// <remarks />
        public TimeState Time
        {
            get
            {
                return m_time;
            }

            set
            {
                if (!Object.ReferenceEquals(m_time, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_time = value;
            }
        }

        /// <remarks />
        public CommunicationState Communication
        {
            get
            {
                return m_communication;
            }

            set
            {
                if (!Object.ReferenceEquals(m_communication, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_communication = value;
            }
        }

        /// <remarks />
        public ZebraSystemState ZebraSystem
        {
            get
            {
                return m_zebraSystem;
            }

            set
            {
                if (!Object.ReferenceEquals(m_zebraSystem, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_zebraSystem = value;
            }
        }

        /// <remarks />
        public IOState IO
        {
            get
            {
                return m_iO;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iO, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iO = value;
            }
        }

        /// <remarks />
        public AnalogItemState<double> MyVariable
        {
            get
            {
                return m_myVariable;
            }

            set
            {
                if (!Object.ReferenceEquals(m_myVariable, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_myVariable = value;
            }
        }

        /// <remarks />
        public FooAnalogItemState MyVariable2
        {
            get
            {
                return m_myVariable2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_myVariable2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_myVariable2 = value;
            }
        }

        /// <remarks />
        public AnalogUnitRangeState MyVariable3
        {
            get
            {
                return m_myVariable3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_myVariable3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_myVariable3 = value;
            }
        }

        /// <remarks />
        public AnalogUnitState MyVariable4
        {
            get
            {
                return m_myVariable4;
            }

            set
            {
                if (!Object.ReferenceEquals(m_myVariable4, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_myVariable4 = value;
            }
        }

        /// <remarks />
        public PropertyState<EUInformation> dummyToBeRemoved
        {
            get
            {
                return m_dummyToBeRemoved;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dummyToBeRemoved, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dummyToBeRemoved = value;
            }
        }

        /// <remarks />
        public MyMethodState MyMethod
        {
            get
            {
                return m_myMethodMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_myMethodMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_myMethodMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_info != null)
            {
                children.Add(m_info);
            }

            if (m_time != null)
            {
                children.Add(m_time);
            }

            if (m_communication != null)
            {
                children.Add(m_communication);
            }

            if (m_zebraSystem != null)
            {
                children.Add(m_zebraSystem);
            }

            if (m_iO != null)
            {
                children.Add(m_iO);
            }

            if (m_myVariable != null)
            {
                children.Add(m_myVariable);
            }

            if (m_myVariable2 != null)
            {
                children.Add(m_myVariable2);
            }

            if (m_myVariable3 != null)
            {
                children.Add(m_myVariable3);
            }

            if (m_myVariable4 != null)
            {
                children.Add(m_myVariable4);
            }

            if (m_dummyToBeRemoved != null)
            {
                children.Add(m_dummyToBeRemoved);
            }

            if (m_myMethodMethod != null)
            {
                children.Add(m_myMethodMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case FooFlt.BrowseNames.Info:
                {
                    if (createOrReplace)
                    {
                        if (Info == null)
                        {
                            if (replacement == null)
                            {
                                Info = new InfoState(this);
                            }
                            else
                            {
                                Info = (InfoState)replacement;
                            }
                        }
                    }

                    instance = Info;
                    break;
                }

                case FooFlt.BrowseNames.Time:
                {
                    if (createOrReplace)
                    {
                        if (Time == null)
                        {
                            if (replacement == null)
                            {
                                Time = new TimeState(this);
                            }
                            else
                            {
                                Time = (TimeState)replacement;
                            }
                        }
                    }

                    instance = Time;
                    break;
                }

                case FooFlt.BrowseNames.Communication:
                {
                    if (createOrReplace)
                    {
                        if (Communication == null)
                        {
                            if (replacement == null)
                            {
                                Communication = new CommunicationState(this);
                            }
                            else
                            {
                                Communication = (CommunicationState)replacement;
                            }
                        }
                    }

                    instance = Communication;
                    break;
                }

                case FooFlt.BrowseNames.ZebraSystem:
                {
                    if (createOrReplace)
                    {
                        if (ZebraSystem == null)
                        {
                            if (replacement == null)
                            {
                                ZebraSystem = new ZebraSystemState(this);
                            }
                            else
                            {
                                ZebraSystem = (ZebraSystemState)replacement;
                            }
                        }
                    }

                    instance = ZebraSystem;
                    break;
                }

                case FooFlt.BrowseNames.IO:
                {
                    if (createOrReplace)
                    {
                        if (IO == null)
                        {
                            if (replacement == null)
                            {
                                IO = new IOState(this);
                            }
                            else
                            {
                                IO = (IOState)replacement;
                            }
                        }
                    }

                    instance = IO;
                    break;
                }

                case FooFlt.BrowseNames.MyVariable:
                {
                    if (createOrReplace)
                    {
                        if (MyVariable == null)
                        {
                            if (replacement == null)
                            {
                                MyVariable = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                MyVariable = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = MyVariable;
                    break;
                }

                case FooFlt.BrowseNames.MyVariable2:
                {
                    if (createOrReplace)
                    {
                        if (MyVariable2 == null)
                        {
                            if (replacement == null)
                            {
                                MyVariable2 = new FooAnalogItemState(this);
                            }
                            else
                            {
                                MyVariable2 = (FooAnalogItemState)replacement;
                            }
                        }
                    }

                    instance = MyVariable2;
                    break;
                }

                case FooFlt.BrowseNames.MyVariable3:
                {
                    if (createOrReplace)
                    {
                        if (MyVariable3 == null)
                        {
                            if (replacement == null)
                            {
                                MyVariable3 = new AnalogUnitRangeState(this);
                            }
                            else
                            {
                                MyVariable3 = (AnalogUnitRangeState)replacement;
                            }
                        }
                    }

                    instance = MyVariable3;
                    break;
                }

                case FooFlt.BrowseNames.MyVariable4:
                {
                    if (createOrReplace)
                    {
                        if (MyVariable4 == null)
                        {
                            if (replacement == null)
                            {
                                MyVariable4 = new AnalogUnitState(this);
                            }
                            else
                            {
                                MyVariable4 = (AnalogUnitState)replacement;
                            }
                        }
                    }

                    instance = MyVariable4;
                    break;
                }

                case FooFlt.BrowseNames.dummyToBeRemoved:
                {
                    if (createOrReplace)
                    {
                        if (dummyToBeRemoved == null)
                        {
                            if (replacement == null)
                            {
                                dummyToBeRemoved = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                dummyToBeRemoved = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = dummyToBeRemoved;
                    break;
                }

                case FooFlt.BrowseNames.MyMethod:
                {
                    if (createOrReplace)
                    {
                        if (MyMethod == null)
                        {
                            if (replacement == null)
                            {
                                MyMethod = new MyMethodState(this);
                            }
                            else
                            {
                                MyMethod = (MyMethodState)replacement;
                            }
                        }
                    }

                    instance = MyMethod;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private InfoState m_info;
        private TimeState m_time;
        private CommunicationState m_communication;
        private ZebraSystemState m_zebraSystem;
        private IOState m_iO;
        private AnalogItemState<double> m_myVariable;
        private FooAnalogItemState m_myVariable2;
        private AnalogUnitRangeState m_myVariable3;
        private AnalogUnitState m_myVariable4;
        private PropertyState<EUInformation> m_dummyToBeRemoved;
        private MyMethodState m_myMethodMethod;
        #endregion
    }
    #endif
    #endregion

    #region InfoState Class
    #if (!OPCUA_EXCLUDE_InfoState)
    /// <summary>
    /// Stores an instance of the InfoType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InfoState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public InfoState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.InfoType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABABAAAABJbmZvVHlwZUluc3RhbmNlAQHROgEB" +
           "0TrROgAA/////wUAAAAVYIkKAgAAAAEABAAAAE5hbWUBAdI6AC4ARNI6AAAADP////8BAf////8AAAAA" +
           "FWCJCgIAAAABAAQAAABUeXBlAQHTOgAuAETTOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAJAAAA" +
           "U1dSZWxlYXNlAQHUOgAuAETUOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVt" +
           "YmVyAQHVOgAuAETVOgAAAAz/////AQH/////AAAAAARggAoBAAAAAQAIAAAATG9jYXRpb24BAdY6AC8B" +
           "Adk61joAAP////8CAAAAFWCJCgIAAAABAAUAAABQbGFudAEB1zoALgBE1zoAAAAM/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEABAAAAFVuaXQBAdg6AC4ARNg6AAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Type
        {
            get
            {
                return m_type;
            }

            set
            {
                if (!Object.ReferenceEquals(m_type, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_type = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SWRelease
        {
            get
            {
                return m_sWRelease;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sWRelease, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sWRelease = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SerialNumber
        {
            get
            {
                return m_serialNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        /// <remarks />
        public LocationState Location
        {
            get
            {
                return m_location;
            }

            set
            {
                if (!Object.ReferenceEquals(m_location, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_location = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_type != null)
            {
                children.Add(m_type);
            }

            if (m_sWRelease != null)
            {
                children.Add(m_sWRelease);
            }

            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_location != null)
            {
                children.Add(m_location);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case FooFlt.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new PropertyState<string>(this);
                            }
                            else
                            {
                                Name = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }

                case FooFlt.BrowseNames.Type:
                {
                    if (createOrReplace)
                    {
                        if (Type == null)
                        {
                            if (replacement == null)
                            {
                                Type = new PropertyState<string>(this);
                            }
                            else
                            {
                                Type = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Type;
                    break;
                }

                case FooFlt.BrowseNames.SWRelease:
                {
                    if (createOrReplace)
                    {
                        if (SWRelease == null)
                        {
                            if (replacement == null)
                            {
                                SWRelease = new PropertyState<string>(this);
                            }
                            else
                            {
                                SWRelease = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SWRelease;
                    break;
                }

                case FooFlt.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case FooFlt.BrowseNames.Location:
                {
                    if (createOrReplace)
                    {
                        if (Location == null)
                        {
                            if (replacement == null)
                            {
                                Location = new LocationState(this);
                            }
                            else
                            {
                                Location = (LocationState)replacement;
                            }
                        }
                    }

                    instance = Location;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_name;
        private PropertyState<string> m_type;
        private PropertyState<string> m_sWRelease;
        private PropertyState<string> m_serialNumber;
        private LocationState m_location;
        #endregion
    }
    #endif
    #endregion

    #region LocationState Class
    #if (!OPCUA_EXCLUDE_LocationState)
    /// <summary>
    /// Stores an instance of the LocationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LocationState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LocationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.LocationType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABABQAAABMb2NhdGlvblR5cGVJbnN0YW5jZQEB" +
           "2ToBAdk62ToAAP////8CAAAAFWCJCgIAAAABAAUAAABQbGFudAEB2joALgBE2joAAAAM/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEABAAAAFVuaXQBAds6AC4ARNs6AAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Plant
        {
            get
            {
                return m_plant;
            }

            set
            {
                if (!Object.ReferenceEquals(m_plant, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_plant = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Unit
        {
            get
            {
                return m_unit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_unit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_unit = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_plant != null)
            {
                children.Add(m_plant);
            }

            if (m_unit != null)
            {
                children.Add(m_unit);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case FooFlt.BrowseNames.Plant:
                {
                    if (createOrReplace)
                    {
                        if (Plant == null)
                        {
                            if (replacement == null)
                            {
                                Plant = new PropertyState<string>(this);
                            }
                            else
                            {
                                Plant = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Plant;
                    break;
                }

                case FooFlt.BrowseNames.Unit:
                {
                    if (createOrReplace)
                    {
                        if (Unit == null)
                        {
                            if (replacement == null)
                            {
                                Unit = new PropertyState<string>(this);
                            }
                            else
                            {
                                Unit = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Unit;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_plant;
        private PropertyState<string> m_unit;
        #endregion
    }
    #endif
    #endregion

    #region TimeState Class
    #if (!OPCUA_EXCLUDE_TimeState)
    /// <summary>
    /// Stores an instance of the TimeType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TimeState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TimeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.TimeType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABABAAAABUaW1lVHlwZUluc3RhbmNlAQHcOgEB" +
           "3DrcOgAA/////wIAAAAEYIAKAQAAAAEACAAAAFNldHRpbmdzAQHdOgAvAQHmOt06AAD/////BQAAABVg" +
           "iQoCAAAAAQAEAAAARGF0ZQEB3joALgBE3joAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABAAAAFRp" +
           "bWUBAd86AC4ARN86AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAgAAABUaW1lWm9uZQEB4DoALgBE" +
           "4DoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAFNvdXJjZQEB4ToALgBE4ToAAAAM/////wEB" +
           "/////wAAAAAEYIAKAQAAAAEACgAAAFNOVFBTZXJ2ZXIBAeI6AC8BAe464joAAP////8CAAAAFWCJCgIA" +
           "AAABAAcAAABFbmFibGVkAQHjOgAuAETjOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAJAAAASVBB" +
           "ZGRyZXNzAQHkOgAuAETkOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAKAAAAQWN0dWFsVGltZQEB" +
           "5ToALgBE5ToAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public TimeSettingsState Settings
        {
            get
            {
                return m_settings;
            }

            set
            {
                if (!Object.ReferenceEquals(m_settings, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_settings = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ActualTime
        {
            get
            {
                return m_actualTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_actualTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actualTime = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_settings != null)
            {
                children.Add(m_settings);
            }

            if (m_actualTime != null)
            {
                children.Add(m_actualTime);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case FooFlt.BrowseNames.Settings:
                {
                    if (createOrReplace)
                    {
                        if (Settings == null)
                        {
                            if (replacement == null)
                            {
                                Settings = new TimeSettingsState(this);
                            }
                            else
                            {
                                Settings = (TimeSettingsState)replacement;
                            }
                        }
                    }

                    instance = Settings;
                    break;
                }

                case FooFlt.BrowseNames.ActualTime:
                {
                    if (createOrReplace)
                    {
                        if (ActualTime == null)
                        {
                            if (replacement == null)
                            {
                                ActualTime = new PropertyState<string>(this);
                            }
                            else
                            {
                                ActualTime = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ActualTime;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private TimeSettingsState m_settings;
        private PropertyState<string> m_actualTime;
        #endregion
    }
    #endif
    #endregion

    #region TimeSettingsState Class
    #if (!OPCUA_EXCLUDE_TimeSettingsState)
    /// <summary>
    /// Stores an instance of the TimeSettingsType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TimeSettingsState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TimeSettingsState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.TimeSettingsType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABABgAAABUaW1lU2V0dGluZ3NUeXBlSW5zdGFu" +
           "Y2UBAeY6AQHmOuY6AAD/////BQAAABVgiQoCAAAAAQAEAAAARGF0ZQEB5zoALgBE5zoAAAAM/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEABAAAAFRpbWUBAeg6AC4AROg6AAAADP////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAgAAABUaW1lWm9uZQEB6ToALgBE6ToAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAFNv" +
           "dXJjZQEB6joALgBE6joAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEACgAAAFNOVFBTZXJ2ZXIBAes6" +
           "AC8BAe466zoAAP////8CAAAAFWCJCgIAAAABAAcAAABFbmFibGVkAQHsOgAuAETsOgAAAAz/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAJAAAASVBBZGRyZXNzAQHtOgAuAETtOgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Date
        {
            get
            {
                return m_date;
            }

            set
            {
                if (!Object.ReferenceEquals(m_date, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_date = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Time
        {
            get
            {
                return m_time;
            }

            set
            {
                if (!Object.ReferenceEquals(m_time, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_time = value;
            }
        }

        /// <remarks />
        public PropertyState<string> TimeZone
        {
            get
            {
                return m_timeZone;
            }

            set
            {
                if (!Object.ReferenceEquals(m_timeZone, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_timeZone = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Source
        {
            get
            {
                return m_source;
            }

            set
            {
                if (!Object.ReferenceEquals(m_source, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_source = value;
            }
        }

        /// <remarks />
        public SNTPServerState SNTPServer
        {
            get
            {
                return m_sNTPServer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sNTPServer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sNTPServer = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_date != null)
            {
                children.Add(m_date);
            }

            if (m_time != null)
            {
                children.Add(m_time);
            }

            if (m_timeZone != null)
            {
                children.Add(m_timeZone);
            }

            if (m_source != null)
            {
                children.Add(m_source);
            }

            if (m_sNTPServer != null)
            {
                children.Add(m_sNTPServer);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case FooFlt.BrowseNames.Date:
                {
                    if (createOrReplace)
                    {
                        if (Date == null)
                        {
                            if (replacement == null)
                            {
                                Date = new PropertyState<string>(this);
                            }
                            else
                            {
                                Date = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Date;
                    break;
                }

                case FooFlt.BrowseNames.Time:
                {
                    if (createOrReplace)
                    {
                        if (Time == null)
                        {
                            if (replacement == null)
                            {
                                Time = new PropertyState<string>(this);
                            }
                            else
                            {
                                Time = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Time;
                    break;
                }

                case FooFlt.BrowseNames.TimeZone:
                {
                    if (createOrReplace)
                    {
                        if (TimeZone == null)
                        {
                            if (replacement == null)
                            {
                                TimeZone = new PropertyState<string>(this);
                            }
                            else
                            {
                                TimeZone = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = TimeZone;
                    break;
                }

                case FooFlt.BrowseNames.Source:
                {
                    if (createOrReplace)
                    {
                        if (Source == null)
                        {
                            if (replacement == null)
                            {
                                Source = new PropertyState<string>(this);
                            }
                            else
                            {
                                Source = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Source;
                    break;
                }

                case FooFlt.BrowseNames.SNTPServer:
                {
                    if (createOrReplace)
                    {
                        if (SNTPServer == null)
                        {
                            if (replacement == null)
                            {
                                SNTPServer = new SNTPServerState(this);
                            }
                            else
                            {
                                SNTPServer = (SNTPServerState)replacement;
                            }
                        }
                    }

                    instance = SNTPServer;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_date;
        private PropertyState<string> m_time;
        private PropertyState<string> m_timeZone;
        private PropertyState<string> m_source;
        private SNTPServerState m_sNTPServer;
        #endregion
    }
    #endif
    #endregion

    #region SNTPServerState Class
    #if (!OPCUA_EXCLUDE_SNTPServerState)
    /// <summary>
    /// Stores an instance of the SNTPServerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SNTPServerState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SNTPServerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.SNTPServerType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABABYAAABTTlRQU2VydmVyVHlwZUluc3RhbmNl" +
           "AQHuOgEB7jruOgAA/////wIAAAAVYIkKAgAAAAEABwAAAEVuYWJsZWQBAe86AC4ARO86AAAADP////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAkAAABJUEFkZHJlc3MBAfA6AC4ARPA6AAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Enabled
        {
            get
            {
                return m_enabled;
            }

            set
            {
                if (!Object.ReferenceEquals(m_enabled, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_enabled = value;
            }
        }

        /// <remarks />
        public PropertyState<string> IPAddress
        {
            get
            {
                return m_iPAddress;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iPAddress, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iPAddress = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_enabled != null)
            {
                children.Add(m_enabled);
            }

            if (m_iPAddress != null)
            {
                children.Add(m_iPAddress);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case FooFlt.BrowseNames.Enabled:
                {
                    if (createOrReplace)
                    {
                        if (Enabled == null)
                        {
                            if (replacement == null)
                            {
                                Enabled = new PropertyState<string>(this);
                            }
                            else
                            {
                                Enabled = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Enabled;
                    break;
                }

                case FooFlt.BrowseNames.IPAddress:
                {
                    if (createOrReplace)
                    {
                        if (IPAddress == null)
                        {
                            if (replacement == null)
                            {
                                IPAddress = new PropertyState<string>(this);
                            }
                            else
                            {
                                IPAddress = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = IPAddress;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_enabled;
        private PropertyState<string> m_iPAddress;
        #endregion
    }
    #endif
    #endregion

    #region CommunicationState Class
    #if (!OPCUA_EXCLUDE_CommunicationState)
    /// <summary>
    /// Stores an instance of the CommunicationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CommunicationState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CommunicationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.CommunicationType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABABkAAABDb21tdW5pY2F0aW9uVHlwZUluc3Rh" +
           "bmNlAQHxOgEB8TrxOgAA/////wIAAAAEYIAKAQAAAAEAEQAAAEV0aGVybmV0SW50ZXJmYWNlAQHyOgAv" +
           "AQH0OvI6AAD/////AAAAAARggAoBAAAAAQADAAAAVVNCAQHzOgAvAQH1OvM6AAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public EthernetInterfaceState EthernetInterface
        {
            get
            {
                return m_ethernetInterface;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ethernetInterface, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ethernetInterface = value;
            }
        }

        /// <remarks />
        public USBState USB
        {
            get
            {
                return m_uSB;
            }

            set
            {
                if (!Object.ReferenceEquals(m_uSB, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_uSB = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_ethernetInterface != null)
            {
                children.Add(m_ethernetInterface);
            }

            if (m_uSB != null)
            {
                children.Add(m_uSB);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case FooFlt.BrowseNames.EthernetInterface:
                {
                    if (createOrReplace)
                    {
                        if (EthernetInterface == null)
                        {
                            if (replacement == null)
                            {
                                EthernetInterface = new EthernetInterfaceState(this);
                            }
                            else
                            {
                                EthernetInterface = (EthernetInterfaceState)replacement;
                            }
                        }
                    }

                    instance = EthernetInterface;
                    break;
                }

                case FooFlt.BrowseNames.USB:
                {
                    if (createOrReplace)
                    {
                        if (USB == null)
                        {
                            if (replacement == null)
                            {
                                USB = new USBState(this);
                            }
                            else
                            {
                                USB = (USBState)replacement;
                            }
                        }
                    }

                    instance = USB;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private EthernetInterfaceState m_ethernetInterface;
        private USBState m_uSB;
        #endregion
    }
    #endif
    #endregion

    #region EthernetInterfaceState Class
    #if (!OPCUA_EXCLUDE_EthernetInterfaceState)
    /// <summary>
    /// Stores an instance of the EthernetInterfaceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EthernetInterfaceState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public EthernetInterfaceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.EthernetInterfaceType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABAB0AAABFdGhlcm5ldEludGVyZmFjZVR5cGVJ" +
           "bnN0YW5jZQEB9DoBAfQ69DoAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region USBState Class
    #if (!OPCUA_EXCLUDE_USBState)
    /// <summary>
    /// Stores an instance of the USBType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class USBState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public USBState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.USBType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABAA8AAABVU0JUeXBlSW5zdGFuY2UBAfU6AQH1" +
           "OvU6AAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ZebraSystemState Class
    #if (!OPCUA_EXCLUDE_ZebraSystemState)
    /// <summary>
    /// Stores an instance of the ZebraSystemType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ZebraSystemState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ZebraSystemState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.ZebraSystemType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABABcAAABaZWJyYVN5c3RlbVR5cGVJbnN0YW5j" +
           "ZQEB9joBAfY69joAAP////8CAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9uAQH3OgAvAQH5Ovc6" +
           "AAD/////AAAAAARggAoBAAAAAQALAAAATWVhc3VyZW1lbnQBAfg6AC8BAfo6+DoAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ConfigurationState Configuration
        {
            get
            {
                return m_configuration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configuration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configuration = value;
            }
        }

        /// <remarks />
        public MeasurementState Measurement
        {
            get
            {
                return m_measurement;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measurement, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measurement = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_measurement != null)
            {
                children.Add(m_measurement);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case FooFlt.BrowseNames.Configuration:
                {
                    if (createOrReplace)
                    {
                        if (Configuration == null)
                        {
                            if (replacement == null)
                            {
                                Configuration = new ConfigurationState(this);
                            }
                            else
                            {
                                Configuration = (ConfigurationState)replacement;
                            }
                        }
                    }

                    instance = Configuration;
                    break;
                }

                case FooFlt.BrowseNames.Measurement:
                {
                    if (createOrReplace)
                    {
                        if (Measurement == null)
                        {
                            if (replacement == null)
                            {
                                Measurement = new MeasurementState(this);
                            }
                            else
                            {
                                Measurement = (MeasurementState)replacement;
                            }
                        }
                    }

                    instance = Measurement;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private ConfigurationState m_configuration;
        private MeasurementState m_measurement;
        #endregion
    }
    #endif
    #endregion

    #region ConfigurationState Class
    #if (!OPCUA_EXCLUDE_ConfigurationState)
    /// <summary>
    /// Stores an instance of the ConfigurationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConfigurationState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConfigurationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.ConfigurationType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABABkAAABDb25maWd1cmF0aW9uVHlwZUluc3Rh" +
           "bmNlAQH5OgEB+Tr5OgAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MeasurementState Class
    #if (!OPCUA_EXCLUDE_MeasurementState)
    /// <summary>
    /// Stores an instance of the MeasurementType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MeasurementState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MeasurementState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.MeasurementType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABABcAAABNZWFzdXJlbWVudFR5cGVJbnN0YW5j" +
           "ZQEB+joBAfo6+joAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region IOState Class
    #if (!OPCUA_EXCLUDE_IOState)
    /// <summary>
    /// Stores an instance of the IOType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IOState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public IOState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.ObjectTypes.IOType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGCAAgEAAAABAA4AAABJT1R5cGVJbnN0YW5jZQEB+zoBAfs6" +
           "+zoAAP////8CAAAABGCACgEAAAABAA0AAABDb25maWd1cmF0aW9uAQH8OgAvAQH5Ovw6AAD/////AAAA" +
           "AARggAoBAAAAAQALAAAATWVhc3VyZW1lbnQBAf06AC8BAfo6/ToAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ConfigurationState Configuration
        {
            get
            {
                return m_configuration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configuration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configuration = value;
            }
        }

        /// <remarks />
        public MeasurementState Measurement
        {
            get
            {
                return m_measurement;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measurement, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measurement = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_measurement != null)
            {
                children.Add(m_measurement);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case FooFlt.BrowseNames.Configuration:
                {
                    if (createOrReplace)
                    {
                        if (Configuration == null)
                        {
                            if (replacement == null)
                            {
                                Configuration = new ConfigurationState(this);
                            }
                            else
                            {
                                Configuration = (ConfigurationState)replacement;
                            }
                        }
                    }

                    instance = Configuration;
                    break;
                }

                case FooFlt.BrowseNames.Measurement:
                {
                    if (createOrReplace)
                    {
                        if (Measurement == null)
                        {
                            if (replacement == null)
                            {
                                Measurement = new MeasurementState(this);
                            }
                            else
                            {
                                Measurement = (MeasurementState)replacement;
                            }
                        }
                    }

                    instance = Measurement;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private ConfigurationState m_configuration;
        private MeasurementState m_measurement;
        #endregion
    }
    #endif
    #endregion

    #region FooAnalogItemState Class
    #if (!OPCUA_EXCLUDE_FooAnalogItemState)
    /// <summary>
    /// Stores an instance of the FooAnalogItemType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FooAnalogItemState : AnalogItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FooAnalogItemState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(FooFlt.VariableTypes.FooAnalogItemType, FooFlt.Namespaces.FooZbrFlt, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(.DataTypes.Number, .Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////FWCJAgIAAAABABkAAABGb29BbmFsb2dJdGVtVHlwZUluc3Rh" +
           "bmNlAQH+OgEB/jr+OgAAABr+////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBAjsALgBE" +
           "AjsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region FooAnalogItemState<T> Class
    /// <summary>
    /// A typed version of the FooAnalogItemType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class FooAnalogItemState<T> : FooAnalogItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public FooAnalogItemState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region MyMethodState Class
    #if (!OPCUA_EXCLUDE_MyMethodState)
    /// <summary>
    /// Stores an instance of the MyMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MyMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MyMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new MyMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAEgAAABodHRwczovL25ldy5mb28uY29tL3plYnJhLWNvbXByZXNzaW9uL2ZsYXR0ZW5pbmctYW5k" +
           "LXN1YnNwYWNlZm9sZGluZy9VQS//////BGGCCgQAAAABAAwAAABNeU1ldGhvZFR5cGUBAQQ7AC8BAQQ7" +
           "BDsAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEFOwAuAEQFOwAAlgIAAAAB" +
           "ACoBARkAAAAKAAAAQWN0aW9uTmFtZQAM/////wAAAAAAAQAqAQEZAAAACgAAAE1ldGhvZE5hbWUADP//" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAQY7AC4ARAY7AACWAQAAAAEAKgEBFQAAAAYAAABSZXN1bHQABv////8AAAAAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public MyMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            string actionName = (string)_inputArguments[0];
            string methodName = (string)_inputArguments[1];

            int result = (int)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    actionName,
                    methodName,
                    ref result);
            }

            _outputArguments[0] = result;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult MyMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string actionName,
        string methodName,
        ref int result);
    #endif
    #endregion
}