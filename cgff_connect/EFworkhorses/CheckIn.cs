using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cgff_connect;
using Dapper;

namespace cgff_connect.EFworkhorses
{

    public static class Group
    {
        public static void UpsertGroup()
        {
            cgff_connect.transactionlog tl = new cgff_connect.transactionlog("start with LINQ", "Before Upsert", "", "group", 0, "EF");
            tl.InsertLog();

            var checkinMax = 0;
            var maxDate = DateTime.Now;

            List<cgff_connect.localModels.Group> localInsertList = new List<localModels.Group>();
            List<cgff_connect.localModels.Group> localUpdateList = new List<localModels.Group>();

            using (var context = new cgff_connect.localModels.CaCgffliveLocalContext())
            {
                checkinMax = (int)context.Groups.Max(i => i.Id);
                maxDate = (DateTime)context.Groups.Max(x => x.ModifiedDate);
            }

            using (var remoteContext = new cgff_connect.remoteModels.CaCgffliveContext())
            {
                var toInsert = remoteContext.Groups.AsParallel().Where(cr => cr.Id >= checkinMax).ToList<cgff_connect.remoteModels.Group>();
                var toUpdate = remoteContext.Groups.AsParallel().Where(cr => cr.ModifiedDate <= maxDate).ToList<cgff_connect.remoteModels.Group>();

                foreach (cgff_connect.remoteModels.Group remoteGroup in toInsert)
                {
                    //localCheckinList.Add(cgff_connect.Converters.RemoteToLocalCheckin(remoteCheckin));
                    cgff_connect.localModels.Group localGroup = new localModels.Group();
                    localInsertList.Add((cgff_connect.localModels.Group)cgff_connect.Converters.RemoteToLocal(remoteGroup, localGroup));
                }
                foreach (cgff_connect.remoteModels.Group remoteGroup in toUpdate)
                {
                    cgff_connect.localModels.Group localGroup = new localModels.Group();
                    localUpdateList.Add((cgff_connect.localModels.Group)cgff_connect.Converters.RemoteToLocal(remoteGroup, localGroup));
                }

            }

            int changeCount = 0;
            using (var localcontext = new cgff_connect.localModels.CaCgffliveLocalContext())
            {
                foreach (cgff_connect.localModels.Group group in localInsertList)
                {
                    if (!localcontext.Groups.Any(e => e.Id == group.Id))
                        localcontext.Groups.Add(group);
                }

                foreach (cgff_connect.localModels.Group group in localUpdateList)
                {
                    if (!localcontext.Groups.Any(e => e.Id == group.Id))
                    {
                        localcontext.Update(group);
                    }
                }
                changeCount = localcontext.SaveChanges();

            }

            tl = new cgff_connect.transactionlog("start with LINQ", "After Upsert", "", "group", changeCount, "EF");
            tl.InsertLog();
        }
    }

    public static class CheckIn
    {
        public static void InsertCheckin()
        {
            cgff_connect.transactionlog tl = new cgff_connect.transactionlog("start with LINQ", "Before Insert", "", "checkin", 0, "EF");
            tl.InsertLog();

            var checkinMax = 0;
            List<cgff_connect.localModels.Checkin> localCheckinList = new List<localModels.Checkin>();

            using (var context = new cgff_connect.localModels.CaCgffliveLocalContext())
            {
                checkinMax = (int)context.Checkins.Max(x => x.Id);
            }

            using (var remoteContext = new cgff_connect.remoteModels.CaCgffliveContext())
            {
                var toInsert = remoteContext.Checkins.AsParallel()
                               .Where(cr => cr.Id >= checkinMax)
                               .ToList<cgff_connect.remoteModels.Checkin>();

                foreach (cgff_connect.remoteModels.Checkin remoteCheckin in toInsert)
                {
                    //localCheckinList.Add(cgff_connect.Converters.RemoteToLocalCheckin(remoteCheckin));
                    cgff_connect.localModels.Checkin localCheckin = new localModels.Checkin();
                    localCheckinList.Add((cgff_connect.localModels.Checkin)cgff_connect.Converters.RemoteToLocal(remoteCheckin, localCheckin));
                }
            }

            int changeCount = 0;
            using (var localcontext = new cgff_connect.localModels.CaCgffliveLocalContext())
            {
                foreach (cgff_connect.localModels.Checkin checkin in localCheckinList)
                {
                    if (!localcontext.Checkins.Any(e => e.Id == checkin.Id))
                        localcontext.Checkins.Add(checkin);
                }
                changeCount = localcontext.SaveChanges();
            }

            tl = new cgff_connect.transactionlog("start with LINQ", "After Insert", "", "checkin", changeCount, "EF");
            tl.InsertLog();
        }
    }

    public static class AccountingGroup
    {

        public static void InsertAccountingGroup()
        {
            cgff_connect.transactionlog tl = new cgff_connect.transactionlog("start with LINQ", "Before Insert", "", "accountinggroup", 0, "EF");
            tl.InsertLog();

            var checkinMax = 0;
            List<cgff_connect.localModels.AccountingGroup> toInserts = new List<localModels.AccountingGroup>();

            using (var context = new cgff_connect.localModels.CaCgffliveLocalContext())
            {
                checkinMax = (int)context.AccountingGroups.Max(x => x.Id);
            }

            using (var remoteContext = new cgff_connect.remoteModels.CaCgffliveContext())
            {
                var toInsert = remoteContext.AccountingGroups.AsParallel()
                               .Where(cr => cr.Id >= checkinMax)
                               .ToList<cgff_connect.remoteModels.AccountingGroup>();

                foreach (cgff_connect.remoteModels.AccountingGroup remote in toInsert)
                {
                    //localCheckinList.Add(cgff_connect.Converters.RemoteToLocalCheckin(remoteCheckin));
                    cgff_connect.localModels.AccountingGroup local = new localModels.AccountingGroup();
                    toInserts.Add((cgff_connect.localModels.AccountingGroup)cgff_connect.Converters.RemoteToLocal(remote, local));
                }
            }

            int changeCount = 0;
            using (var localcontext = new cgff_connect.localModels.CaCgffliveLocalContext())
            {
                foreach (cgff_connect.localModels.AccountingGroup newInsert in toInserts)
                {
                    if (!localcontext.AccountingGroups.Any(e => e.Id == newInsert.Id))
                        localcontext.AccountingGroups.Add(newInsert);
                }
                changeCount = localcontext.SaveChanges();
            }

            tl = new cgff_connect.transactionlog("start with LINQ", "After Insert", "", "accountinggroup", changeCount, "EF");
            tl.InsertLog();
        }
    }

    public static class AccountingGroupItems
    {
        public static void InsertAccountingGroupItems()
        {
            cgff_connect.transactionlog tl = new cgff_connect.transactionlog("start with LINQ", "Before Insert", "", "accountinggroupitems", 0, "EF");
            tl.InsertLog();

            var checkinMax = 0;
            List<cgff_connect.localModels.AccountingGroupItem> toInserts = new List<localModels.AccountingGroupItem>();

            using (var context = new cgff_connect.localModels.CaCgffliveLocalContext())
            {
                checkinMax = (int)context.AccountingGroupItems.Max(x => x.Id);
            }

            using (var remoteContext = new cgff_connect.remoteModels.CaCgffliveContext())
            {
                var toInsert = remoteContext.AccountingGroupItems.AsParallel()
                               .Where(cr => cr.Id >= checkinMax)
                               .ToList<cgff_connect.remoteModels.AccountingGroupItem>();

                foreach (cgff_connect.remoteModels.AccountingGroupItem remote in toInsert)
                {
                    //localCheckinList.Add(cgff_connect.Converters.RemoteToLocalCheckin(remoteCheckin));
                    cgff_connect.localModels.AccountingGroupItem local = new localModels.AccountingGroupItem();
                    toInserts.Add((cgff_connect.localModels.AccountingGroupItem)cgff_connect.Converters.RemoteToLocal(remote, local));
                }
            }

            int changeCount = 0;
            using (var localcontext = new cgff_connect.localModels.CaCgffliveLocalContext())
            {
                foreach (cgff_connect.localModels.AccountingGroupItem newInsert in toInserts)
                {
                    if (!localcontext.AccountingGroupItems.Any(e => e.Id == newInsert.Id))
                        localcontext.AccountingGroupItems.Add(newInsert);
                }
                changeCount = localcontext.SaveChanges();
            }

            tl = new cgff_connect.transactionlog("start with LINQ", "After Insert", "", "accountinggroupitems", changeCount, "EF");
            tl.InsertLog();
        }

    }

    public static class Calendar
    {
        public static void InsertCalendar()
        {
            cgff_connect.transactionlog tl = new cgff_connect.transactionlog("start with LINQ", "Before Insert", "", "Calendar", 0, "EF");
            tl.InsertLog();

            var checkinMax = 0;
            List<cgff_connect.localModels.Calendar> toInserts = new List<localModels.Calendar>();

            using (var context = new cgff_connect.localModels.CaCgffliveLocalContext())
            {
                checkinMax = (int)context.Calendars.Max(x => x.Id);
            }

            using (var remoteContext = new cgff_connect.remoteModels.CaCgffliveContext())
            {
                var toInsert = remoteContext.Calendars.AsParallel()
                               .Where(cr => cr.Id >= checkinMax)
                               .ToList<cgff_connect.remoteModels.Calendar>();

                foreach (cgff_connect.remoteModels.Calendar remote in toInsert)
                {
                    //localCheckinList.Add(cgff_connect.Converters.RemoteToLocalCheckin(remoteCheckin));
                    cgff_connect.localModels.Calendar local = new localModels.Calendar();
                    toInserts.Add((cgff_connect.localModels.Calendar)cgff_connect.Converters.RemoteToLocal(remote, local));
                }
            }

            int changeCount = 0;
            using (var localcontext = new cgff_connect.localModels.CaCgffliveLocalContext())
            {
                foreach (cgff_connect.localModels.Calendar newInsert in toInserts)
                {
                    if (!localcontext.Calendars.Any(e => e.Id == newInsert.Id))
                        localcontext.Calendars.Add(newInsert);
                }
                changeCount = localcontext.SaveChanges();
            }

            tl = new cgff_connect.transactionlog("start with LINQ", "After Insert", "", "Calendar", changeCount, "EF");
            tl.InsertLog();
        }
    }

    public static class Charge
    {
        public static void UpsertCharge()
        {
            cgff_connect.transactionlog tl = new cgff_connect.transactionlog("start with LINQ", "Before Upsert", "", "charge", 0, "EF");
            tl.InsertLog();

            var checkinMax = 0;
            var maxDate = DateTime.Now;

            List<cgff_connect.localModels.Charge> localInsertList = new List<localModels.Charge>();
            List<cgff_connect.localModels.Charge> localUpdateList = new List<localModels.Charge>();

            using (var context = new cgff_connect.localModels.CaCgffliveLocalContext())
            {
                checkinMax = (int)context.Charges.Max(i => i.Id);
                maxDate = (DateTime)context.Charges.Max(x => x.ModifiedDate);
            }

            using (var remoteContext = new cgff_connect.remoteModels.CaCgffliveContext())
            {
                var toInsert = remoteContext.Charges.AsParallel().Where(cr => cr.Id > (ulong)checkinMax).ToList<cgff_connect.remoteModels.Charge>();
                //var toUpdate = remoteContext.Charges.AsParallel().Where(cr => cr.ModifiedDate > maxDate).ToList<cgff_connect.remoteModels.Charge>();

                foreach (cgff_connect.remoteModels.Charge remoteGroup in toInsert)
                {
                    //localCheckinList.Add(cgff_connect.Converters.RemoteToLocalCheckin(remoteCheckin));
                    cgff_connect.localModels.Charge localGroup = new localModels.Charge();
                    localInsertList.Add((cgff_connect.localModels.Charge)cgff_connect.Converters.RemoteToLocal(remoteGroup, localGroup));
                }
                //foreach (cgff_connect.remoteModels.Charge remoteGroup in toUpdate)
                //{
                //    cgff_connect.localModels.Charge localGroup = new localModels.Charge();
                //    localUpdateList.Add((cgff_connect.localModels.Charge)cgff_connect.Converters.RemoteToLocal(remoteGroup, localGroup));
                //}

            }

            int changeCount = 0;
            using (var localcontext = new cgff_connect.localModels.CaCgffliveLocalContext())
            {
                foreach (cgff_connect.localModels.Charge group in localInsertList)
                {
                    if (!localcontext.Charges.Any(e => e.Id == group.Id))
                    {
                        localcontext.Charges.Add(group);
                        changeCount += localcontext.SaveChanges();
                    }
                }

                //foreach (cgff_connect.localModels.Charge group in localUpdateList)
                //{
                //    if (localcontext.Charges.Any(e => e.Id == group.Id))
                //    {
                //        localcontext.Update(group);
                //    }
                //}
                

            }

            tl = new cgff_connect.transactionlog("start with LINQ", "After Upsert", "", "charge", changeCount, "EF");
            tl.InsertLog();
        }


    }



}
