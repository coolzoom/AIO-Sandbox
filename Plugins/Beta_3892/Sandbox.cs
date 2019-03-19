﻿using Beta_3892.Handlers;
using Common.Interfaces;
using Common.Interfaces.Handlers;

namespace Beta_3892
{
    public class Sandbox : ISandbox
    {
        public static Sandbox Instance => _instance;
        private static readonly Sandbox _instance = new Sandbox();

        public string RealmName { get; set; } = "|cFF00FFFFBeta 3 (0.10.0/0.11.0) Sandbox";
        public int Build { get; set; } = 3892;
        public int RealmPort { get; set; } = 3724;
        public int RedirectPort { get; set; } = 9002;
        public int WorldPort { get; set; } = 8129;

        public IOpcodes Opcodes { get; set; } = new Opcodes();

        public IAuthHandler AuthHandler { get; set; } = new AuthHandler();
        public ICharHandler CharHandler { get; set; } = new CharHandler();
        public IWorldHandler WorldHandler { get; set; } = new WorldHandler();

        public IPacketReader ReadPacket(byte[] data, bool parse = true) => new PacketReader(data, parse);

        public IPacketWriter WritePacket() => new PacketWriter();
    }
}
