﻿namespace AssettoServer.Network.Packets
{
    public enum ACServerProtocol : byte
    {
        P2PUpdate            = 0x0D,
        MandatoryPitUpdate   = 0x0E,
        Handshake            = 0x3B,
        WrongPassword        = 0x3C,
        RequestNewConnection = 0x3D,
        NewCarConnection     = 0x3E,  // Sent as a response to a handshake
        CarListRequest       = 0x3F,
        CarList              = 0x40,
        ServerRunning        = 0x41,
        UnsupportedProtocol  = 0x42,
        CleanExitDrive       = 0x43,  // Driver does clean disconnect
        Checksum             = 0x44,
        NoSlotsAvailable     = 0x45,
        PositionUpdate       = 0x46,
        Chat                 = 0x47,
        MegaPacket           = 0x48,
        LapCompleted         = 0x49,
        CurrentSessionUpdate = 0x4A,
        RaceOver             = 0x4B,
        Pulse                = 0x4C,  // Not exactly sure what this does
        CarDisconnect        = 0x4E,
        SessionRequest       = 0x4F,
        CarDisconnected      = 0x4D,
        TyreCompoundChange   = 0x50,
        WelcomeMessage       = 0x51,
        CarSetup             = 0x52,
        DrsZonesUpdate       = 0x53,
        CarConnected         = 0x5A,
        DriverInfoUpdate     = 0x5B,
        SunAngleUpdate       = 0x54,
        DamageUpdate         = 0x56,
        RaceStart            = 0x57,
        SectorSplit          = 0x58,
        VoteNextSession      = 0x64,
        VoteRestartSession   = 0x65,
        VoteKickUser         = 0x66,
        VoteQuorumNotReached = 0x67,
        KickCar              = 0x68,
        SessionClosed        = 0x6E,
        AuthFailed           = 0x6F,
        BoPUpdate            = 0x70,  // Ballast and restrictor
        WeatherUpdate        = 0x78,
        ClientEvent          = 0x82,
        Extended             = 0xAB,
        LobbyCheck           = 0xC8,
        PingPong             = 0xF8,
        PingUpdate           = 0xF9,
    }

    public enum UdpPluginProtocol : byte
    {
        CollisionWithCar     = 0x0A,
        CollisionWithEnv     = 0x0B,
        NewSession           = 0x32,
        NewConnection        = 0x33,
        ClosedConnection     = 0x34,
        CarUpdate            = 0x35,
        CarInfo              = 0x36,
        EndSession           = 0x37,
        Version              = 0x38,
        Chat                 = 0x39,
        ClientFirstUpdate    = 0x3A,
        SessionInfo          = 0x3B,
        Error                = 0x3C,
        LapCompleted         = 0x49,
        ClientEvent          = 0x82,
        RealtimePosInterval  = 0xC8,
        GetCarInfo           = 0xC9,
        SendChat             = 0xCA,  // sends chat to single car
        BroadcastChat        = 0xCB,  // sends chat to everyone
        GetSessionInfo       = 0xCC,
        SetSessionInfo       = 0xCD,
        KickUser             = 0xCE,
        NextSession          = 0xCF,
        RestartSession       = 0xD0,
        AdminCommand         = 0xD1,
    }

    public enum CSPMessageTypeTcp : byte
    {
        SpectateCar         = 0x00,
        WeatherUpdate       = 0x01,
        CarVisibilityUpdate = 0x02,
        ClientMessage       = 0x03,
        SystemMessage       = 0x04,
        KickBanMessage      = 0x05,
    }

    public enum CSPMessageTypeUdp : byte
    {
        CustomUpdate        = 0x03,
    }
}
