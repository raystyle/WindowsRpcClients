//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\AppVEntSubsystemController.dll
// Interface ID: 6d809348-7e6c-41b9-91bc-630fe5503d66
// Interface Version: 1.0



namespace rpc_6d809348_7e6c_41b9_91bc_630fe5503d66_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(string[] p0, long p1)
        {
            WriteConformantStringArray(p0, new System.Action<string>(this.WriteTerminatedString), p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public string[] Read_0()
        {
            return ReadConformantStringArray(new System.Func<string>(this.ReadConformantVaryingString));
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("6d809348-7e6c-41b9-91bc-630fe5503d66", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int vobjects_server_GetObjectExclusions(int p0, System.Guid p1, System.Guid p2, out long p3, out int p4, out int p5, out string[] p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteGuid(p1);
            m.WriteGuid(p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            p3 = u.ReadInt64();
            p4 = u.ReadInt32();
            p5 = u.ReadInt32();
            p6 = u.ReadReferent<string[]>(new System.Func<string[]>(u.Read_0), false);
            return u.ReadInt32();
        }
    }
    #endregion
}

