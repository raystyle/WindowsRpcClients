//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\msdtcprx.dll
// Interface ID: 906b0ce0-c70b-1067-b317-00dd010662da
// Interface Version: 1.0



namespace rpc_906b0ce0_c70b_1067_b317_00dd010662da_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_3(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_4(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
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
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public sbyte[] Read_2()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_3()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_4()
        {
            return ReadConformantArray<sbyte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public int MemberC;
        public int Member10;
        public int Member14;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, int Member4, int Member8, int MemberC, int Member10, int Member14)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member14 = Member14;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, int Member4, int Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("906b0ce0-c70b-1067-b317-00dd010662da", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int Poke(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, string p1, string p2, string p3, int p4, sbyte[] p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteInt32(p4);
            m.Write_2(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"), p4);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int BuildContext(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, Struct_0 p1, string p2, string p3, string p4, string p5, ref string p6, ref Struct_1 p7, int p8, sbyte[] p9, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p10)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.Write_0(p1);
            m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"));
            m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p6, "p6"));
            m.Write_1(p7);
            m.WriteInt32(p8);
            m.Write_3(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p9, "p9"), p8);
            _Unmarshal_Helper u = SendReceive(1, m);
            p6 = u.ReadConformantVaryingAnsiString();
            p7 = u.Read_1();
            p10 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int NegotiateResources(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, int p2, ref int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteEnum16(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(2, m);
            p3 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int SendReceive(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, sbyte[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int TearDownContext(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteEnum16(p1);
            m.WriteEnum16(p2);
            _Unmarshal_Helper u = SendReceive(4, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int BeginTearDown(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteEnum16(p1);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        public int PokeW(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, string p1, string p2, string p3, int p4, sbyte[] p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteInt32(p4);
            m.Write_2(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"), p4);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
        public int BuildContextW(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, Struct_0 p1, string p2, string p3, string p4, string p5, ref string p6, ref Struct_1 p7, int p8, sbyte[] p9, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p10)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.Write_0(p1);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p6, "p6"));
            m.Write_1(p7);
            m.WriteInt32(p8);
            m.Write_3(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p9, "p9"), p8);
            _Unmarshal_Helper u = SendReceive(7, m);
            p6 = u.ReadConformantVaryingString();
            p7 = u.Read_1();
            p10 = u.ReadContextHandle();
            return u.ReadInt32();
        }
    }
    #endregion
}

