using System.Collections.Generic;
using lab6._5;

IResistanse ires = new TotalConnection();
IResistanse iires = new SeriesConnection();
var sender = new ResistanceSender(ires);
sender.ProcessResistance();
var sender1 = new ResistanceSender(iires);
sender1.ProcessResistance();