
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class maginciatinkersAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {10569, -8, 0, 1}, {10569, -8, -1, 1}, {10571, -8, -8, 21}// 1	2	3	
			, {10568, -8, -3, 21}, {10568, -8, -2, 21}, {10568, -8, 0, 21}// 4	5	6	
			, {10568, -8, -1, 21}, {10572, -8, -8, 1}, {10568, -8, -6, 21}// 7	8	9	
			, {10568, -8, -5, 21}, {10568, -8, -4, 21}, {10568, -8, -7, 21}// 10	11	12	
			, {10569, -8, -7, 1}, {10569, -8, -6, 1}, {10569, -8, -5, 1}// 13	14	15	
			, {10569, -8, -4, 1}, {10569, -8, -3, 1}, {10569, -8, -2, 1}// 16	17	18	
			, {10569, -8, 8, 1}, {10569, -8, 1, 1}, {10569, -8, 2, 1}// 19	20	21	
			, {10568, -8, 4, 21}, {10568, -8, 2, 21}, {10569, -8, 3, 1}// 22	23	24	
			, {10568, -8, 1, 21}, {10568, -8, 3, 21}, {10569, -8, 4, 1}// 25	26	27	
			, {10569, -8, 7, 1}, {10569, -8, 6, 1}, {10569, -8, 5, 1}// 28	29	30	
			, {10568, -8, 5, 21}, {10568, -8, 6, 21}, {10568, -8, 7, 21}// 31	32	33	
			, {10568, -8, 8, 21}, {4183, 3, -4, 7}, {10568, 8, -3, 21}// 34	36	37	
			, {10568, 8, -2, 21}, {10575, -5, -8, 1}, {10568, 8, -5, 21}// 38	39	40	
			, {5738, -1, -4, 1}, {10569, 8, -4, 1}, {10568, 8, 0, 21}// 41	42	43	
			, {10574, 2, -8, 21}, {5739, 1, -4, 1}, {5736, -5, 0, 0}// 44	45	46	
			, {10574, -1, -8, 21}, {10574, -3, -8, 21}, {10574, -2, -8, 21}// 47	48	49	
			, {10568, 8, -4, 21}, {10574, 6, -8, 21}, {10574, 4, -8, 21}// 50	51	52	
			, {10575, 3, -8, 1}, {10574, -5, -8, 21}, {10575, -1, -8, 1}// 53	54	55	
			, {10574, 8, -8, 21}, {5736, -5, -2, 0}, {10568, 8, -1, 21}// 56	57	58	
			, {5739, 2, -4, 1}, {10569, 8, -2, 1}, {10575, -2, -8, 1}// 59	60	61	
			, {10574, 0, -8, 21}, {10575, 4, -8, 1}, {10574, -4, -8, 21}// 62	63	64	
			, {10574, 7, -8, 21}, {10574, 1, -8, 21}, {10575, 6, -8, 1}// 65	66	67	
			, {10575, 2, -8, 1}, {5739, 4, -4, 1}, {10569, 8, -3, 1}// 68	69	70	
			, {10575, -3, -8, 1}, {10575, -4, -8, 1}, {10568, 8, -6, 21}// 71	72	73	
			, {5739, 0, -4, 1}, {10575, -7, -8, 1}, {10568, 8, -7, 21}// 74	75	76	
			, {5739, 3, -4, 1}, {10575, 7, -8, 1}, {10575, 8, -8, 1}// 77	78	79	
			, {10575, -6, -8, 1}, {5740, 5, -4, 1}, {10569, 8, -6, 1}// 80	81	82	
			, {10574, 3, -8, 21}, {5737, -5, -3, 0}, {5736, -5, -1, 0}// 83	84	85	
			, {10575, 0, -8, 1}, {10569, 8, -5, 1}, {10575, 1, -8, 1}// 86	87	88	
			, {5736, 6, 0, 1}, {10575, 5, -8, 1}, {10574, -7, -8, 21}// 89	90	91	
			, {5737, 6, -1, 1}, {10574, 5, -8, 21}, {10574, -6, -8, 21}// 92	93	94	
			, {10569, 8, -7, 1}, {10569, 8, -1, 1}, {10569, 8, 0, 1}// 95	96	97	
			, {1267, -7, -7, 21}, {1267, -7, -6, 21}, {1267, -7, -5, 21}// 98	99	100	
			, {1267, -7, -4, 21}, {1267, -7, -3, 21}, {1267, -7, -2, 21}// 101	102	103	
			, {1267, -7, -1, 21}, {1267, -7, 0, 21}, {1267, -6, -7, 21}// 104	105	106	
			, {1267, -6, -6, 21}, {1267, -6, -5, 21}, {1267, -6, -4, 21}// 107	108	109	
			, {1267, -6, -3, 21}, {1267, -6, -2, 21}, {1267, -6, -1, 21}// 110	111	112	
			, {1267, -6, 0, 21}, {1267, -5, -7, 21}, {1267, -5, -6, 21}// 113	114	115	
			, {1267, -5, -5, 21}, {1267, -5, -4, 21}, {1267, -5, -3, 21}// 116	117	118	
			, {1267, -5, -2, 21}, {1267, -5, -1, 21}, {1267, -5, 0, 21}// 119	120	121	
			, {1267, -4, -7, 21}, {1267, -4, -6, 21}, {1267, -4, -5, 21}// 122	123	124	
			, {1267, -4, -4, 21}, {1267, -4, -3, 21}, {1267, -4, -2, 21}// 125	126	127	
			, {1267, -4, -1, 21}, {1267, -4, 0, 21}, {1267, -3, -7, 21}// 128	129	130	
			, {1267, -3, -6, 21}, {1267, -3, -5, 21}, {1267, -3, -4, 21}// 131	132	133	
			, {1267, -3, -3, 21}, {1267, -3, -2, 21}, {1267, -3, -1, 21}// 134	135	136	
			, {1267, -3, 0, 21}, {1267, -2, -7, 21}, {1267, -2, -6, 21}// 137	138	139	
			, {1267, -2, -5, 21}, {1267, -2, -4, 21}, {1267, -2, -3, 21}// 140	141	142	
			, {1267, -2, -2, 21}, {1267, -2, -1, 21}, {1267, -2, 0, 21}// 143	144	145	
			, {1267, -1, -7, 21}, {1267, -1, -6, 21}, {1267, -1, -5, 21}// 146	147	148	
			, {1267, -1, -4, 21}, {1267, -1, -3, 21}, {1267, -1, -2, 21}// 149	150	151	
			, {1267, -1, -1, 21}, {1267, -1, 0, 21}, {1267, 0, -7, 21}// 152	153	154	
			, {1267, 0, -6, 21}, {1267, 0, -5, 21}, {1267, 0, -4, 21}// 155	156	157	
			, {1267, 0, -3, 21}, {1267, 0, -2, 21}, {1267, 0, -1, 21}// 158	159	160	
			, {1267, 0, 0, 21}, {1267, 1, -7, 21}, {1267, 1, -6, 21}// 161	162	163	
			, {1267, 1, -5, 21}, {1267, 1, -4, 21}, {1267, 1, -3, 21}// 164	165	166	
			, {1267, 1, -2, 21}, {1267, 1, -1, 21}, {1267, 1, 0, 21}// 167	168	169	
			, {1267, 2, -7, 21}, {1267, 2, -6, 21}, {1267, 2, -5, 21}// 170	171	172	
			, {1267, 2, -4, 21}, {1267, 2, -3, 21}, {1267, 2, -2, 21}// 173	174	175	
			, {1267, 2, -1, 21}, {1267, 2, 0, 21}, {1267, 3, -7, 21}// 176	177	178	
			, {1267, 3, -6, 21}, {1267, 3, -5, 21}, {1267, 3, -4, 21}// 179	180	181	
			, {1267, 3, -3, 21}, {1267, 3, -2, 21}, {1267, 3, -1, 21}// 182	183	184	
			, {1267, 3, 0, 21}, {1267, 4, -7, 21}, {1267, 4, -6, 21}// 185	186	187	
			, {1267, 4, -5, 21}, {1267, 4, -4, 21}, {1267, 4, -3, 21}// 188	189	190	
			, {1267, 4, -2, 21}, {1267, 4, -1, 21}, {1267, 4, 0, 21}// 191	192	193	
			, {1267, 5, -7, 21}, {1267, 5, -6, 21}, {1267, 5, -5, 21}// 194	195	196	
			, {1267, 5, -4, 21}, {1267, 5, -3, 21}, {1267, 5, -2, 21}// 197	198	199	
			, {1267, 5, -1, 21}, {1267, 5, 0, 21}, {1267, 6, -7, 21}// 200	201	202	
			, {1267, 6, -6, 21}, {1267, 6, -5, 21}, {1267, 6, -4, 21}// 203	204	205	
			, {1267, 6, -3, 21}, {1267, 6, -2, 21}, {1267, 6, -1, 21}// 206	207	208	
			, {1267, 6, 0, 21}, {1267, 7, -7, 21}, {1267, 7, -6, 21}// 209	210	211	
			, {1267, 7, -5, 21}, {1267, 7, -4, 21}, {1267, 7, -3, 21}// 212	213	214	
			, {1267, 7, -2, 21}, {1267, 7, -1, 21}, {1267, 7, 0, 21}// 215	216	217	
			, {1267, 8, -7, 21}, {1267, 8, -6, 21}, {1267, 8, -5, 21}// 218	219	220	
			, {1267, 8, -4, 21}, {1267, 8, -3, 21}, {1267, 8, -2, 21}// 221	222	223	
			, {1267, 8, -1, 21}, {1267, 8, 0, 21}, {4183, 3, -4, 5}// 224	225	226	
			, {4183, 0, 4, 6}, {10574, -6, 8, 21}, {10575, -5, 8, 1}// 227	228	229	
			, {10574, 6, 8, 21}, {1267, 3, 8, 21}, {1267, -4, 7, 21}// 230	231	232	
			, {1267, -3, 7, 21}, {10568, 8, 5, 21}, {10568, 8, 8, 21}// 233	234	235	
			, {10575, -6, 8, 1}, {10568, 8, 6, 21}, {5735, -5, 3, 0}// 236	237	238	
			, {10568, 8, 7, 21}, {1267, -2, 8, 21}, {10574, 1, 8, 21}// 240	241	242	
			, {1267, 8, 8, 21}, {10574, -1, 8, 21}, {1267, -1, 8, 21}// 243	244	245	
			, {5739, 2, 4, 0}, {1267, -6, 8, 21}, {10574, 5, 8, 21}// 246	247	248	
			, {1267, -1, 7, 21}, {1267, 5, 8, 21}, {1267, 6, 7, 21}// 249	250	251	
			, {10574, 0, 8, 21}, {1267, -2, 7, 21}, {1267, 7, 7, 21}// 252	253	254	
			, {10574, 4, 8, 21}, {10568, 8, 1, 21}, {5736, -5, 2, 0}// 255	256	257	
			, {1267, -4, 8, 21}, {10574, 7, 8, 21}, {5739, 0, 4, 0}// 258	259	260	
			, {1267, 4, 8, 21}, {1267, -5, 7, 21}, {10569, 8, 7, 1}// 261	262	263	
			, {1267, 0, 7, 21}, {1267, -3, 8, 21}, {10575, -2, 8, 1}// 264	265	266	
			, {10574, 2, 8, 21}, {1267, -7, 8, 21}, {10574, 8, 8, 21}// 267	268	269	
			, {1267, 1, 7, 21}, {1267, 7, 8, 21}, {10568, 8, 2, 21}// 270	271	272	
			, {1267, 2, 8, 21}, {1267, -5, 8, 21}, {10569, 8, 6, 1}// 273	274	275	
			, {1267, 4, 7, 21}, {1267, 3, 7, 21}, {1267, 2, 7, 21}// 276	277	278	
			, {1267, 5, 7, 21}, {10566, 8, 8, 1}, {5738, -1, 4, 0}// 279	280	281	
			, {10574, 3, 8, 21}, {1267, -7, 7, 21}, {1267, -6, 7, 21}// 282	283	284	
			, {10569, 8, 4, 1}, {10569, 8, 3, 1}, {5739, 4, 4, 0}// 285	286	287	
			, {5740, 5, 4, 0}, {5735, 6, 1, 1}, {1267, 8, 7, 21}// 288	289	290	
			, {10575, -1, 8, 1}, {5736, -5, 1, 0}, {10574, -2, 8, 21}// 291	292	293	
			, {10574, -5, 8, 21}, {1267, 0, 8, 21}, {1267, 1, 8, 21}// 294	295	296	
			, {1267, 6, 8, 21}, {10568, 8, 3, 21}, {10568, 8, 4, 21}// 297	298	299	
			, {10574, -7, 8, 21}, {5739, 3, 4, 0}, {5739, 1, 4, 0}// 300	301	302	
			, {10575, -7, 8, 1}, {10574, -3, 8, 21}, {10574, -4, 8, 21}// 303	304	305	
			, {10569, 8, 5, 1}, {10575, 0, 8, 1}, {10575, 1, 8, 1}// 306	307	308	
			, {10575, 2, 8, 1}, {10575, 3, 8, 1}, {10575, 4, 8, 1}// 309	310	311	
			, {10575, 5, 8, 1}, {10575, 6, 8, 1}, {10575, 7, 8, 1}// 312	313	314	
			, {10569, 8, 1, 1}, {10569, 8, 2, 1}, {1267, -7, 6, 21}// 315	316	317	
			, {1267, -6, 6, 21}, {1267, -5, 6, 21}, {1267, -4, 6, 21}// 318	319	320	
			, {1267, -3, 6, 21}, {1267, -2, 6, 21}, {1267, -1, 6, 21}// 321	322	323	
			, {1267, 0, 6, 21}, {1267, 1, 6, 21}, {1267, 2, 6, 21}// 324	325	326	
			, {1267, 3, 6, 21}, {1267, 4, 6, 21}, {1267, 5, 6, 21}// 327	328	329	
			, {1267, 6, 6, 21}, {1267, 7, 6, 21}, {1267, 8, 6, 21}// 330	331	332	
			, {1267, -7, 5, 21}, {1267, -6, 5, 21}, {1267, -5, 5, 21}// 333	334	335	
			, {1267, -4, 5, 21}, {1267, -3, 5, 21}, {1267, -2, 5, 21}// 336	337	338	
			, {1267, -1, 5, 21}, {1267, 0, 5, 21}, {1267, 1, 5, 21}// 339	340	341	
			, {1267, 2, 5, 21}, {1267, 3, 5, 21}, {1267, 4, 5, 21}// 342	343	344	
			, {1267, 5, 5, 21}, {1267, 6, 5, 21}, {1267, 7, 5, 21}// 345	346	347	
			, {1267, 8, 5, 21}, {1267, -7, 4, 21}, {1267, -6, 4, 21}// 348	349	350	
			, {1267, -5, 4, 21}, {1267, -4, 4, 21}, {1267, -3, 4, 21}// 351	352	353	
			, {1267, -2, 4, 21}, {1267, -1, 4, 21}, {1267, 0, 4, 21}// 354	355	356	
			, {1267, 1, 4, 21}, {1267, 2, 4, 21}, {1267, 3, 4, 21}// 357	358	359	
			, {1267, 4, 4, 21}, {1267, 5, 4, 21}, {1267, 6, 4, 21}// 360	361	362	
			, {1267, 7, 4, 21}, {1267, 8, 4, 21}, {1267, -7, 3, 21}// 363	364	365	
			, {1267, -6, 3, 21}, {1267, -5, 3, 21}, {1267, -4, 3, 21}// 366	367	368	
			, {1267, -3, 3, 21}, {1267, -2, 3, 21}, {1267, -1, 3, 21}// 369	370	371	
			, {1267, 0, 3, 21}, {1267, 1, 3, 21}, {1267, 2, 3, 21}// 372	373	374	
			, {1267, 3, 3, 21}, {1267, 4, 3, 21}, {1267, 5, 3, 21}// 375	376	377	
			, {1267, 6, 3, 21}, {1267, 7, 3, 21}, {1267, 8, 3, 21}// 378	379	380	
			, {1267, -7, 1, 21}, {1267, -7, 2, 21}, {1267, -6, 1, 21}// 381	382	383	
			, {1267, -6, 2, 21}, {1267, -5, 1, 21}, {1267, -5, 2, 21}// 384	385	386	
			, {1267, -4, 1, 21}, {1267, -4, 2, 21}, {1267, -3, 1, 21}// 387	388	389	
			, {1267, -3, 2, 21}, {1267, -2, 1, 21}, {1267, -2, 2, 21}// 390	391	392	
			, {1267, -1, 1, 21}, {1267, -1, 2, 21}, {1267, 0, 1, 21}// 393	394	395	
			, {1267, 0, 2, 21}, {1267, 1, 1, 21}, {1267, 1, 2, 21}// 396	397	398	
			, {1267, 2, 1, 21}, {1267, 2, 2, 21}, {1267, 3, 1, 21}// 399	400	401	
			, {1267, 3, 2, 21}, {1267, 4, 1, 21}, {1267, 4, 2, 21}// 402	403	404	
			, {1267, 5, 1, 21}, {1267, 5, 2, 21}, {1267, 6, 1, 21}// 405	406	407	
			, {1267, 6, 2, 21}, {1267, 7, 1, 21}, {1267, 7, 2, 21}// 408	409	410	
			, {1267, 8, 1, 21}, {1267, 8, 2, 21}, {4183, 0, 4, 5}// 411	412	413	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new maginciatinkersAddonDeed();
			}
		}

		[ Constructable ]
		public maginciatinkersAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2852, -8, 9, 3, 0, 1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 2852, 0, 9, 3, 0, 1, "", 1);// 239

		}

		public maginciatinkersAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class maginciatinkersAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new maginciatinkersAddon();
			}
		}

		[Constructable]
		public maginciatinkersAddonDeed()
		{
			Name = "maginciatinkers";
		}

		public maginciatinkersAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}