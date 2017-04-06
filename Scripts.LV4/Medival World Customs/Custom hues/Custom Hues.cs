//###########################################################//
// CREATED BY FOREST CONDON AKA FCONDON AKA EXALE
// MYSTICALNIGHTS.ORG
// PLEASE LEAVE HEADER INTACT.
//###########################################################//

using System;
using Server;
 
namespace Server.AllHues
{
    public class AllHuesInfo
    {
        public static int Rare
        {
            get
            {
                return Utility.RandomList
                (
				1458, 1459, 1460, 1461, 1462, 1463, 1464, 1465, 1466, 1467,
				1468, 1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477,
				1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1567, 1568,
				1569, 1570, 1571, 1572, 1573, 1574, 1575, 1576, 1577, 1578,
				1579, 1580, 1581, 1582, 1583, 1584, 1585, 1586, 1587, 1665,
				1666, 1667, 1668, 1669, 1670, 1671, 1672, 1673, 1785, 1786,
				1787, 1788, 1789, 1790, 1791, 1792, 1793, 1794, 1795, 1796,
				1797, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 1917, 1918,
				1919, 1920, 1921, 1922, 1923, 1924, 1925, 1926, 1927, 1928,
				1929, 1930, 1931, 1932, 1933, 1934, 1935, 1936, 1937, 1938, //100
				1939, 1940, 1941, 1942, 1943, 1944, 1945, 1946, 1947, 1948,
				1949, 1950, 1951, 1952, 1953, 1954, 1955, 1956, 1957, 1958,
				1959, 1960, 1961, 1962, 1963, 1964, 1965, 1966, 1967, 1968, 
				1969, 1970, 1971, 1972, 1973, 1974, 1975, 1976, 1977, 1978, 
				1979, 1980, 1981, 1982, 1983, 1984, 1985, 1986, 1987, 1988,
				1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 2019,
				2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029,
				2030, 2031, 2032, 2033, 2034, 2035, 2036, 2037, 2038, 2039,
				2040, 2041, 2042, 2043, 2044, 2045, 2046, 2047, 2048, 2049,
				2050, 2051, 2052, 2058, 2059, 2060, 2061, 2062, 2063, 2064, //200
				2065, 2066, 2067, 2069, 2070, 2071, 2072, 2075, 2076, 2077,
				2078, 2079, 2080, 2081, 2082, 2083, 2084, 2085, 2086, 2087,
				2088, 2089, 2090, 2091, 2092, 2093, 2094, 2095, 2137, 2138,
				2139, 2140, 2141, 2142, 2143, 2144, 2145, 2146, 2147, 2148,
				2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158,
				2159, 2160, 2161, 2162, 2163, 2164, 2165, 2166, 2167, 2168,
				2169, 2170, 2171, 2172, 2173, 2174, 2175, 2176, 2177, 2178,
				2179, 2180, 2181, 2182, 2183, 2184, 2185, 2186, 2187, 2188,
				2189, 2190, 2191, 2192, 2193, 2194, 2195, 2196, 2197, 2226,
				2227, 2228, 2229, 2230, 2231, 2233, 2237, 2238, 2239, 2240, //300
				2241, 2242, 2243, 2244, 2245, 2246, 2247, 2248, 2249, 2250,
				2251, 2252, 2254, 2256, 2257, 2258, 2259, 2260, 2261, 2262,
				2263, 2264, 2265, 2266, 2272, 2273, 2274, 2275, 2279, 2280,
				2282, 2283, 2284, 2285, 2286, 2287, 2288, 2289, 2290, 2291,
				2292, 2293, 2294, 2295, 2319, 2320, 2321, 2322, 2323, 2324,
				2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332, 2333, 2334, 
				2335, 2344, 2345, 2346, 2347, 2348, 2349, 2350, 2351, 2352,
				2353, 2354, 2355, 2356, 2357, 2358, 2359, 2360, 2361, 2362,
				2363, 2364, 2365, 2366, 2367, 2368, 2369, 2370, 2371, 2372,
				2373, 2374, 2375, 2376, 2377, 2378, 2382, 2386, 2387, 2388, //400
				2389, 2390, 2391, 2392, 2393, 2394, 2395, 2396, 2397, 2398,
				2399, 2340, 2431, 2432, 2433, 2434, 2435, 2436, 2437, 2438,
				2439, 2440, 2441, 2442, 2443, 2444, 2445, 2446, 2447, 2448,
				2449, 2450, 2451, 2452, 2453, 2454, 2455, 2456, 2457, 2462,
				2463, 2465, 2466, 2467, 2468, 2469, 2470, 2471, 2472, 2473,
				2474, 2475, 2476, 2477, 2478, 2479, 2480, 2481, 2482, 2483,
				2484, 2485, 2486, 2487, 2489, 2490, 2491, 2492, 2498, 2499,
				2663, 2664, 2665, 2666, 2721, 2728, 2729, 2730, 2731, 2732,
				2733, 2734, 2735, 2736, 2737, 2738, 2739, 2740, 2741, 2742,
				2743, 2744, 2745, 2746, 2747, 2748, 2749, 2750, 2760, 2762, //500
				2763, 2771, 2772, 2773, 2774, 2775, 2776, 2778, 2779, 2780,
				2781, 2782, 2783, 2784, 2786, 2788, 2789, 2790, 2791, 2792,
				2793, 2794, 2795, 2796, 2797, 2798, 2803, 2805, 2806, 2807,
				2808, 2834, 2839, 2840, 2841, 2842, 2843, 2844, 2845, 2848,
				2849, 2850, 2851, 2852, 2856, 2857, 2858, 2859, 2860, 2861,
				2862, 2863, 2864, 2865, 2866, 2867, 2868, 2869, 2870, 2880,
				2913, 2920, 2921, 2922, 2923, 2924, 2929, 2931, 2932, 2934,
				2935, 2936, 2937, 2947, 2972, 2973, 2974, 2975, 2976, 2978,
				2979, 2980, 2981, 2982, 2983, 2984, 2985, 2986, 2987, 2989,
				2990, 2991, 2992, 2993, 2994, 2995, 2996, 2997, 2998, 2999, //600
				3000
                );
            }
        }
 
 
    }
}