﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Delta.Model.Interfaces;

namespace Delta.Trinity.Auth
{
    public partial class BattlenetAccount : IUser
    {
        public BattlenetAccount()
        {
            Account = new HashSet<Account>();
            BattlenetItemAppearances = new HashSet<BattlenetItemAppearances>();
            BattlenetItemFavoriteAppearances = new HashSet<BattlenetItemFavoriteAppearances>();
        }
        
        public BattlenetAccount(string email, string shaPassHash)
        {
            Email = email.ToUpper(CultureInfo.InvariantCulture);
            ShaPassHash = shaPassHash.ToUpper(CultureInfo.InvariantCulture);
            Account = new HashSet<Account>();
            BattlenetItemAppearances = new HashSet<BattlenetItemAppearances>();
            BattlenetItemFavoriteAppearances = new HashSet<BattlenetItemFavoriteAppearances>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string ShaPassHash { get; set; }
        public DateTimeOffset Joindate { get; set; }
        public string LastIp { get; set; }
        public int FailedLogins { get; set; }
        public byte Locked { get; set; }
        public string LockCountry { get; set; }
        public DateTimeOffset? LastLogin { get; set; }
        public byte Online { get; set; }
        public byte Locale { get; set; }
        public string Os { get; set; }
        public int LastCharacterUndelete { get; set; }
        public string LoginTicket { get; set; }
        public int? LoginTicketExpiry { get; set; }

        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<BattlenetItemAppearances> BattlenetItemAppearances { get; set; }
        public virtual ICollection<BattlenetItemFavoriteAppearances> BattlenetItemFavoriteAppearances { get; set; }
    }
}
