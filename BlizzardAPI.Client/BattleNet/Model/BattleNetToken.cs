﻿namespace BlizzardAPI.Client.BattleNet.Model
{
    public class BattleNetToken
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public int ExpiresIn { get; set; }
        public string Scope { get; set; }
    }
}