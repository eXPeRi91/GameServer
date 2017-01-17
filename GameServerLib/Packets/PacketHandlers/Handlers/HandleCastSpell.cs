﻿using ENet;
using LeagueSandbox.GameServer.GameObjects;
using LeagueSandbox.GameServer.Players;

namespace LeagueSandbox.GameServer.Packets.PacketHandlers.Handlers
{
    class HandleCastSpell : IPacketHandler
    {
        private Game _game = Program.ResolveDependency<Game>();
        private NetworkIdManager _networkIdManager = Program.ResolveDependency<NetworkIdManager>();
        private PlayerManager _playerManager = Program.ResolveDependency<PlayerManager>();

        public bool HandlePacket(Peer peer, byte[] data)
        {
            var spell = new CastSpell(data);
            //Todo spellslot 0-3 qwer, 4-5 d f, 6-11 items

            // There are some bits triggering this
            /*if ((spell.spellSlotType & 0x0F) > 0)
            {
                Logger.LogCoreInfo("Summoner Spell Cast");
                Logger.LogCoreInfo("Type: " + spell.spellSlotType.ToString("x") + ", Slot " + spell.spellSlot + ", coord " + spell.x + " ; " + spell.y + ", coord2 " + spell.x2 + ", " + spell.y2 + ", target NetId " + spell.targetNetId.ToString("x"));
                return true;
            }*/

            var futureProjNetId = _networkIdManager.GetNewNetID();
            var spellNetId = _networkIdManager.GetNewNetID();
            var targetObj = _game.Map.GetObjectById(spell.targetNetId);
            var TargetUnit = targetObj as Unit;

            var s = _playerManager.GetPeerInfo(peer).Champion.castSpell(
                spell.spellSlot, spell.x, spell.y, TargetUnit, futureProjNetId, spellNetId
            );

            if (s == null)
            {
                return false;
            }

            var response = new CastSpellAns(s, spell.x, spell.y, spell.x2, spell.y2, futureProjNetId, spellNetId);
            _game.PacketHandlerManager.broadcastPacket(response, Channel.CHL_S2C);
            return true;
        }
    }
}
