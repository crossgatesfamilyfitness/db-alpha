﻿using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class HistoricalTransaction
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateOnly Date { get; set; }
}
