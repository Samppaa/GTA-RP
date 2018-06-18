﻿using System;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Managers;

namespace GTA_RP.Factions
{

    class TaxiDriverCommands : FactionCommands
    {

        [Command("startmeter")]
        public void StartTaxiMeterForCharacterWithId(Client client, int id)
        {
            Character character = PlayerManager.Instance().GetActiveCharacterForClient(client);
            if (IsCharacterValid(character, FactionI.TAXI_DRIVER) && PlayerManager.Instance().IsCharacterWithIdOnline(id))
            {
                FactionManager.Instance().TaxiDriver().SetTaxiMeterForCharacter(character, PlayerManager.Instance().GetCharacterWithId(id));
            }
        }

        [Command("paytaxifee")]
        public void PayTaxiMeterFee(Client client)
        {
            Character character = PlayerManager.Instance().GetActiveCharacterForClient(client);
            if (IsCharacterValid(character))
            {
                FactionManager.Instance().TaxiDriver().PayTaxiMeterFee(character);
            }
        }

        [Command("stopmeter")]
        public void StopMeterForCharacterWithId(Client client, int id)
        {
            Character character = PlayerManager.Instance().GetActiveCharacterForClient(client);
            if (IsCharacterValid(character, FactionI.TAXI_DRIVER) && PlayerManager.Instance().IsCharacterWithIdOnline(id))
            {
                FactionManager.Instance().TaxiDriver().StopTaxiMeterForCharacter(character, PlayerManager.Instance().GetCharacterWithId(id));
            }
        }

    }
}