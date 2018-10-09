﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWorx.Core.Math
{
    public class z
    {
        private static readonly decimal[] zs = new decimal[619];
        static z()
        {
            Initialize();
        }

        private static void Initialize()
        {
            zs[0] = 0.5000m;
            zs[1] = 0.5040m;
            zs[2] = 0.5080m;
            zs[3] = 0.5120m;
            zs[4] = 0.5160m;
            zs[5] = 0.5199m;
            zs[6] = 0.5239m;
            zs[7] = 0.5279m;
            zs[8] = 0.5319m;
            zs[9] = 0.5359m;
            zs[10] = 0.5398m;
            zs[11] = 0.5438m;
            zs[12] = 0.5478m;
            zs[13] = 0.5517m;
            zs[14] = 0.5557m;
            zs[15] = 0.5596m;
            zs[16] = 0.5636m;
            zs[17] = 0.5675m;
            zs[18] = 0.5714m;
            zs[19] = 0.5753m;
            zs[20] = 0.5793m;
            zs[21] = 0.5832m;
            zs[22] = 0.5871m;
            zs[23] = 0.5910m;
            zs[24] = 0.5948m;
            zs[25] = 0.5987m;
            zs[26] = 0.6026m;
            zs[27] = 0.6064m;
            zs[28] = 0.6103m;
            zs[29] = 0.6141m;
            zs[30] = 0.6179m;
            zs[31] = 0.6217m;
            zs[32] = 0.6255m;
            zs[33] = 0.6293m;
            zs[34] = 0.6331m;
            zs[35] = 0.6368m;
            zs[36] = 0.6406m;
            zs[37] = 0.6443m;
            zs[38] = 0.6480m;
            zs[39] = 0.6517m;
            zs[40] = 0.6554m;
            zs[41] = 0.6591m;
            zs[42] = 0.6628m;
            zs[43] = 0.6664m;
            zs[44] = 0.6700m;
            zs[45] = 0.6736m;
            zs[46] = 0.6772m;
            zs[47] = 0.6808m;
            zs[48] = 0.6844m;
            zs[49] = 0.6879m;
            zs[50] = 0.6915m;
            zs[51] = 0.6950m;
            zs[52] = 0.6985m;
            zs[53] = 0.7019m;
            zs[54] = 0.7054m;
            zs[55] = 0.7088m;
            zs[56] = 0.7123m;
            zs[57] = 0.7157m;
            zs[58] = 0.7190m;
            zs[59] = 0.7224m;
            zs[60] = 0.7257m;
            zs[61] = 0.7291m;
            zs[62] = 0.7324m;
            zs[63] = 0.7357m;
            zs[64] = 0.7389m;
            zs[65] = 0.7422m;
            zs[66] = 0.7454m;
            zs[67] = 0.7486m;
            zs[68] = 0.7517m;
            zs[69] = 0.7549m;
            zs[70] = 0.7580m;
            zs[71] = 0.7611m;
            zs[72] = 0.7642m;
            zs[73] = 0.7673m;
            zs[74] = 0.7704m;
            zs[75] = 0.7734m;
            zs[76] = 0.7764m;
            zs[77] = 0.7794m;
            zs[78] = 0.7823m;
            zs[79] = 0.7852m;
            zs[80] = 0.7881m;
            zs[81] = 0.7910m;
            zs[82] = 0.7939m;
            zs[83] = 0.7967m;
            zs[84] = 0.7995m;
            zs[85] = 0.8023m;
            zs[86] = 0.8051m;
            zs[87] = 0.8078m;
            zs[88] = 0.8106m;
            zs[89] = 0.8133m;
            zs[90] = 0.8159m;
            zs[91] = 0.8186m;
            zs[92] = 0.8212m;
            zs[93] = 0.8238m;
            zs[94] = 0.8264m;
            zs[95] = 0.8289m;
            zs[96] = 0.8315m;
            zs[97] = 0.8340m;
            zs[98] = 0.8365m;
            zs[99] = 0.8389m;
            zs[100] = 0.8413m;
            zs[101] = 0.8438m;
            zs[102] = 0.8461m;
            zs[103] = 0.8485m;
            zs[104] = 0.8508m;
            zs[105] = 0.8531m;
            zs[106] = 0.8554m;
            zs[107] = 0.8577m;
            zs[108] = 0.8599m;
            zs[109] = 0.8621m;
            zs[110] = 0.8643m;
            zs[111] = 0.8665m;
            zs[112] = 0.8686m;
            zs[113] = 0.8708m;
            zs[114] = 0.8729m;
            zs[115] = 0.8749m;
            zs[116] = 0.8770m;
            zs[117] = 0.8790m;
            zs[118] = 0.8810m;
            zs[119] = 0.8830m;
            zs[120] = 0.8849m;
            zs[121] = 0.8869m;
            zs[122] = 0.8888m;
            zs[123] = 0.8907m;
            zs[124] = 0.8925m;
            zs[125] = 0.8944m;
            zs[126] = 0.8962m;
            zs[127] = 0.8980m;
            zs[128] = 0.8997m;
            zs[129] = 0.9015m;
            zs[130] = 0.9032m;
            zs[131] = 0.9049m;
            zs[132] = 0.9066m;
            zs[133] = 0.9082m;
            zs[134] = 0.9099m;
            zs[135] = 0.9115m;
            zs[136] = 0.9131m;
            zs[137] = 0.9147m;
            zs[138] = 0.9162m;
            zs[139] = 0.9177m;
            zs[140] = 0.9192m;
            zs[141] = 0.9207m;
            zs[142] = 0.9222m;
            zs[143] = 0.9236m;
            zs[144] = 0.9251m;
            zs[145] = 0.9265m;
            zs[146] = 0.9279m;
            zs[147] = 0.9292m;
            zs[148] = 0.9306m;
            zs[149] = 0.9319m;
            zs[150] = 0.9332m;
            zs[151] = 0.9345m;
            zs[152] = 0.9357m;
            zs[153] = 0.9370m;
            zs[154] = 0.9382m;
            zs[155] = 0.9394m;
            zs[156] = 0.9406m;
            zs[157] = 0.9418m;
            zs[158] = 0.9429m;
            zs[159] = 0.9441m;
            zs[160] = 0.9452m;
            zs[161] = 0.9463m;
            zs[162] = 0.9474m;
            zs[163] = 0.9484m;
            zs[164] = 0.9495m;
            zs[165] = 0.9505m;
            zs[166] = 0.9515m;
            zs[167] = 0.9525m;
            zs[168] = 0.9535m;
            zs[169] = 0.9545m;
            zs[170] = 0.9554m;
            zs[171] = 0.9564m;
            zs[172] = 0.9573m;
            zs[173] = 0.9582m;
            zs[174] = 0.9591m;
            zs[175] = 0.9599m;
            zs[176] = 0.9608m;
            zs[177] = 0.9616m;
            zs[178] = 0.9625m;
            zs[179] = 0.9633m;
            zs[180] = 0.9641m;
            zs[181] = 0.9649m;
            zs[182] = 0.9656m;
            zs[183] = 0.9664m;
            zs[184] = 0.9671m;
            zs[185] = 0.9678m;
            zs[186] = 0.9686m;
            zs[187] = 0.9693m;
            zs[188] = 0.9699m;
            zs[189] = 0.9706m;
            zs[190] = 0.9713m;
            zs[191] = 0.9719m;
            zs[192] = 0.9726m;
            zs[193] = 0.9732m;
            zs[194] = 0.9738m;
            zs[195] = 0.9744m;
            zs[196] = 0.9750m;
            zs[197] = 0.9756m;
            zs[198] = 0.9761m;
            zs[199] = 0.9767m;
            zs[200] = 0.9772m;
            zs[201] = 0.9778m;
            zs[202] = 0.9783m;
            zs[203] = 0.9788m;
            zs[204] = 0.9793m;
            zs[205] = 0.9798m;
            zs[206] = 0.9803m;
            zs[207] = 0.9808m;
            zs[208] = 0.9812m;
            zs[209] = 0.9817m;
            zs[210] = 0.9821m;
            zs[211] = 0.9826m;
            zs[212] = 0.9830m;
            zs[213] = 0.9834m;
            zs[214] = 0.9838m;
            zs[215] = 0.9842m;
            zs[216] = 0.9846m;
            zs[217] = 0.9850m;
            zs[218] = 0.9854m;
            zs[219] = 0.9857m;
            zs[220] = 0.9861m;
            zs[221] = 0.9864m;
            zs[222] = 0.9868m;
            zs[223] = 0.9871m;
            zs[224] = 0.9875m;
            zs[225] = 0.9878m;
            zs[226] = 0.9881m;
            zs[227] = 0.9884m;
            zs[228] = 0.9887m;
            zs[229] = 0.9890m;
            zs[230] = 0.9893m;
            zs[231] = 0.9896m;
            zs[232] = 0.9898m;
            zs[233] = 0.9901m;
            zs[234] = 0.9904m;
            zs[235] = 0.9906m;
            zs[236] = 0.9909m;
            zs[237] = 0.9911m;
            zs[238] = 0.9913m;
            zs[239] = 0.9916m;
            zs[240] = 0.9918m;
            zs[241] = 0.9920m;
            zs[242] = 0.9922m;
            zs[243] = 0.9925m;
            zs[244] = 0.9927m;
            zs[245] = 0.9929m;
            zs[246] = 0.9931m;
            zs[247] = 0.9932m;
            zs[248] = 0.9934m;
            zs[249] = 0.9936m;
            zs[250] = 0.9938m;
            zs[251] = 0.9940m;
            zs[252] = 0.9941m;
            zs[253] = 0.9943m;
            zs[254] = 0.9945m;
            zs[255] = 0.9946m;
            zs[256] = 0.9948m;
            zs[257] = 0.9949m;
            zs[258] = 0.9951m;
            zs[259] = 0.9952m;
            zs[260] = 0.9953m;
            zs[261] = 0.9955m;
            zs[262] = 0.9956m;
            zs[263] = 0.9957m;
            zs[264] = 0.9959m;
            zs[265] = 0.9960m;
            zs[266] = 0.9961m;
            zs[267] = 0.9962m;
            zs[268] = 0.9963m;
            zs[269] = 0.9964m;
            zs[270] = 0.9965m;
            zs[271] = 0.9966m;
            zs[272] = 0.9967m;
            zs[273] = 0.9968m;
            zs[274] = 0.9969m;
            zs[275] = 0.9970m;
            zs[276] = 0.9971m;
            zs[277] = 0.9972m;
            zs[278] = 0.9973m;
            zs[279] = 0.9974m;
            zs[280] = 0.9974m;
            zs[281] = 0.9975m;
            zs[282] = 0.9976m;
            zs[283] = 0.9977m;
            zs[284] = 0.9977m;
            zs[285] = 0.9978m;
            zs[286] = 0.9979m;
            zs[287] = 0.9979m;
            zs[288] = 0.9980m;
            zs[289] = 0.9981m;
            zs[290] = 0.9981m;
            zs[291] = 0.9982m;
            zs[292] = 0.9982m;
            zs[293] = 0.9983m;
            zs[294] = 0.9984m;
            zs[295] = 0.9984m;
            zs[296] = 0.9985m;
            zs[297] = 0.9985m;
            zs[298] = 0.9986m;
            zs[299] = 0.9986m;
            zs[300] = 0.9987m;
            zs[301] = 0.9987m;
            zs[302] = 0.9987m;
            zs[303] = 0.9988m;
            zs[304] = 0.9988m;
            zs[305] = 0.9989m;
            zs[306] = 0.9989m;
            zs[307] = 0.9989m;
            zs[308] = 0.9990m;
            zs[309] = 0.9990m;
        }

        public static decimal normsinv(decimal probability)
        {
            return zscore(probability);
        }

        public static decimal zscore(decimal rand)
        {
            // all we can tolerate ;)
            rand = round(rand);

            if (rand == 0.5000m)
                return 0m;

            // negative
            bool isNegative = rand < 0.5000m;
            if (isNegative)
                rand = 1 - rand;

            // find index
            int index = Array.BinarySearch<decimal>(zs, rand);
            decimal zidx = 0m;
            if (index < 0) // did not find exactly
            {
                index = ~index;
                decimal low = index == 0 ? index : index - 1;
                decimal high = index == zs.Length ? index - 1 : index;
                // somewhere in between
                zidx = (low + high) / 200m;
            }
            else // found exact match
                zidx = index / 100m;

            // z-score
            return isNegative ? -zidx : zidx;
        }

        private static decimal round(decimal d, int decimals = 4)
        {
            return System.Math.Round(d, decimals);
        }
    }
}
