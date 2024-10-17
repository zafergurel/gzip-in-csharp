using System;
using System.IO;
using System.IO.Compression;

public class FileCompressionModeExample
{
    private const string Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
    private const string OriginalFileName = "original.txt";
    private const string CompressedFileName = "compressed.gz";
    private const string DecompressedFileName = "decompressed.txt";

    public static void Main()
    {
        CreateFileToCompress();
        CompressFile();
        DecompressFile();
        PrintResults();
        DeleteFiles();

        /*
         Output:

            The original file 'original.txt' is 445 bytes. Contents: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."

            The compressed file 'compressed.gz' is 283 bytes.

            The decompressed file 'decompressed.txt' is 445 bytes. Contents: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
         */
    }

    private static void CreateFileToCompress() => File.WriteAllText(OriginalFileName, Data);

    private static void CompressFile()
    {
        using FileStream originalFileStream = File.Open(OriginalFileName, FileMode.Open);
        using FileStream compressedFileStream = File.Create(CompressedFileName);
        using var compressor = new GZipStream(compressedFileStream, CompressionMode.Compress);
        originalFileStream.CopyTo(compressor);
    }

    private static void DecompressFile()
    {
        using FileStream compressedFileStream = File.Open(CompressedFileName, FileMode.Open);
        using FileStream outputFileStream = File.Create(DecompressedFileName);
        using var decompressor = new GZipStream(compressedFileStream, CompressionMode.Decompress);
        decompressor.CopyTo(outputFileStream);
    }

    private static void PrintResults()
    {
        long originalSize = new FileInfo(OriginalFileName).Length;
        long compressedSize = new FileInfo(CompressedFileName).Length;
        long decompressedSize = new FileInfo(DecompressedFileName).Length;

        /*
		Console.WriteLine($"The original file '{OriginalFileName}' is {originalSize} bytes. Contents: \"{File.ReadAllText(OriginalFileName)}\"");
        Console.WriteLine($"The compressed file '{CompressedFileName}' is {compressedSize} bytes.");
        Console.WriteLine($"The decompressed file '{DecompressedFileName}' is {decompressedSize} bytes. Contents: \"{File.ReadAllText(DecompressedFileName)}\"");
		*/
		Console.WriteLine($"The original file '{OriginalFileName}' is {originalSize} bytes. ");
        Console.WriteLine($"The compressed file '{CompressedFileName}' is {compressedSize} bytes.");
        Console.WriteLine($"The decompressed file '{DecompressedFileName}' is {decompressedSize} bytes. ");
    }

    private static void DeleteFiles()
    {
        File.Delete(OriginalFileName);
        File.Delete(CompressedFileName);
        File.Delete(DecompressedFileName);
    }
	
	public static string Data="""
		{
  "type": "excalidraw",
  "version": 2,
  "source": "https://cdn-ngn.percul.us",
  "elements": [
    {
      "id": "ltT-1avRWonIGAlIM4lx1",
      "type": "freedraw",
      "x": 638,
      "y": 257,
      "width": 203,
      "height": 158,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 1998655789,
      "version": 17,
      "versionNonce": 964511363,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152202237,
      "link": null,
      "locked": false,
      "customData": {
        "order": 1
      },
      "points": [
        [
          0,
          0
        ],
        [
          -15,
          12
        ],
        [
          -26,
          21
        ],
        [
          -40,
          34
        ],
        [
          -56,
          50
        ],
        [
          -68,
          63
        ],
        [
          -72,
          69
        ],
        [
          -71,
          72
        ],
        [
          -62,
          72
        ],
        [
          -43,
          77
        ],
        [
          34,
          93
        ],
        [
          88,
          104
        ],
        [
          118,
          117
        ],
        [
          127,
          128
        ],
        [
          131,
          158
        ],
        [
          131,
          158
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        131,
        158
      ]
    },
    {
      "id": "h2Ci2YoRKhzb7CTdqwl9l",
      "type": "freedraw",
      "x": 756,
      "y": 328,
      "width": 215,
      "height": 350,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 1292485059,
      "version": 29,
      "versionNonce": 1884434243,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152202942,
      "link": null,
      "locked": false,
      "customData": {
        "order": 2
      },
      "points": [
        [
          0,
          0
        ],
        [
          32,
          -18
        ],
        [
          69,
          -36
        ],
        [
          108,
          -52
        ],
        [
          158,
          -69
        ],
        [
          174,
          -76
        ],
        [
          185,
          -85
        ],
        [
          181,
          -93
        ],
        [
          169,
          -100
        ],
        [
          153,
          -104
        ],
        [
          108,
          -102
        ],
        [
          82,
          -95
        ],
        [
          47,
          -81
        ],
        [
          28,
          -66
        ],
        [
          24,
          -57
        ],
        [
          29,
          -27
        ],
        [
          46,
          -5
        ],
        [
          69,
          19
        ],
        [
          108,
          56
        ],
        [
          159,
          98
        ],
        [
          192,
          135
        ],
        [
          209,
          167
        ],
        [
          214,
          183
        ],
        [
          215,
          208
        ],
        [
          210,
          236
        ],
        [
          207,
          242
        ],
        [
          203,
          246
        ],
        [
          203,
          246
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        203,
        246
      ]
    },
    {
      "id": "VgJqZAD57N1mpH1ViJkWC",
      "type": "freedraw",
      "x": 1181,
      "y": 421,
      "width": 350,
      "height": 413,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 1154185859,
      "version": 38,
      "versionNonce": 498941091,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152203792,
      "link": null,
      "locked": false,
      "customData": {
        "order": 3
      },
      "points": [
        [
          0,
          0
        ],
        [
          6,
          -9
        ],
        [
          8,
          -17
        ],
        [
          9,
          -25
        ],
        [
          7,
          -43
        ],
        [
          6,
          -46
        ],
        [
          -4,
          -61
        ],
        [
          -4,
          -63
        ],
        [
          -6,
          -65
        ],
        [
          -12,
          -70
        ],
        [
          -26,
          -82
        ],
        [
          -44,
          -94
        ],
        [
          -68,
          -107
        ],
        [
          -89,
          -118
        ],
        [
          -118,
          -130
        ],
        [
          -143,
          -140
        ],
        [
          -141,
          -139
        ],
        [
          -95,
          -109
        ],
        [
          -24,
          -28
        ],
        [
          3,
          41
        ],
        [
          6,
          86
        ],
        [
          3,
          141
        ],
        [
          -15,
          184
        ],
        [
          -41,
          220
        ],
        [
          -63,
          240
        ],
        [
          -95,
          258
        ],
        [
          -131,
          270
        ],
        [
          -201,
          273
        ],
        [
          -233,
          270
        ],
        [
          -276,
          260
        ],
        [
          -305,
          248
        ],
        [
          -324,
          234
        ],
        [
          -337,
          215
        ],
        [
          -340,
          196
        ],
        [
          -341,
          181
        ],
        [
          -341,
          173
        ],
        [
          -341,
          173
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        -341,
        173
      ]
    },
    {
      "id": "z8PJ5Minl_YdbrHaaC7Mf",
      "type": "freedraw",
      "x": 609,
      "y": 480,
      "width": 648,
      "height": 591,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 1008381923,
      "version": 111,
      "versionNonce": 1600183757,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152205988,
      "link": null,
      "locked": false,
      "customData": {
        "order": 4
      },
      "points": [
        [
          0,
          0
        ],
        [
          -2,
          -1
        ],
        [
          -2,
          -2
        ],
        [
          -2,
          -5
        ],
        [
          -2,
          -7
        ],
        [
          -2,
          -8
        ],
        [
          0,
          -10
        ],
        [
          5,
          -14
        ],
        [
          5,
          -16
        ],
        [
          5,
          -20
        ],
        [
          -3,
          -35
        ],
        [
          -22,
          -54
        ],
        [
          -60,
          -66
        ],
        [
          -98,
          -66
        ],
        [
          -210,
          -23
        ],
        [
          -262,
          3
        ],
        [
          -277,
          13
        ],
        [
          -283,
          25
        ],
        [
          -274,
          41
        ],
        [
          -263,
          53
        ],
        [
          -241,
          73
        ],
        [
          -217,
          88
        ],
        [
          -188,
          100
        ],
        [
          -142,
          109
        ],
        [
          -124,
          111
        ],
        [
          -102,
          108
        ],
        [
          -85,
          96
        ],
        [
          -71,
          61
        ],
        [
          -66,
          37
        ],
        [
          -62,
          14
        ],
        [
          -61,
          10
        ],
        [
          -58,
          12
        ],
        [
          -50,
          18
        ],
        [
          -34,
          24
        ],
        [
          -12,
          29
        ],
        [
          12,
          29
        ],
        [
          39,
          18
        ],
        [
          53,
          2
        ],
        [
          54,
          -2
        ],
        [
          53,
          -2
        ],
        [
          40,
          10
        ],
        [
          -1,
          58
        ],
        [
          -36,
          119
        ],
        [
          -60,
          171
        ],
        [
          -68,
          192
        ],
        [
          -73,
          210
        ],
        [
          -73,
          214
        ],
        [
          -68,
          200
        ],
        [
          -56,
          162
        ],
        [
          -30,
          55
        ],
        [
          -16,
          -43
        ],
        [
          -12,
          -106
        ],
        [
          -12,
          -180
        ],
        [
          -26,
          -257
        ],
        [
          -40,
          -274
        ],
        [
          -62,
          -283
        ],
        [
          -87,
          -280
        ],
        [
          -115,
          -259
        ],
        [
          -138,
          -224
        ],
        [
          -142,
          -201
        ],
        [
          -142,
          -186
        ],
        [
          -140,
          -179
        ],
        [
          -138,
          -179
        ],
        [
          -131,
          -184
        ],
        [
          -114,
          -194
        ],
        [
          -96,
          -202
        ],
        [
          -55,
          -211
        ],
        [
          -43,
          -212
        ],
        [
          -38,
          -215
        ],
        [
          -40,
          -223
        ],
        [
          -69,
          -249
        ],
        [
          -107,
          -274
        ],
        [
          -137,
          -295
        ],
        [
          -148,
          -307
        ],
        [
          -153,
          -326
        ],
        [
          -143,
          -351
        ],
        [
          -133,
          -361
        ],
        [
          -119,
          -370
        ],
        [
          -89,
          -377
        ],
        [
          -58,
          -377
        ],
        [
          0,
          -376
        ],
        [
          51,
          -371
        ],
        [
          124,
          -365
        ],
        [
          189,
          -358
        ],
        [
          221,
          -351
        ],
        [
          228,
          -346
        ],
        [
          229,
          -337
        ],
        [
          228,
          -323
        ],
        [
          211,
          -290
        ],
        [
          194,
          -268
        ],
        [
          165,
          -237
        ],
        [
          142,
          -217
        ],
        [
          132,
          -208
        ],
        [
          126,
          -201
        ],
        [
          119,
          -195
        ],
        [
          112,
          -188
        ],
        [
          105,
          -182
        ],
        [
          104,
          -183
        ],
        [
          103,
          -190
        ],
        [
          98,
          -208
        ],
        [
          84,
          -243
        ],
        [
          63,
          -278
        ],
        [
          35,
          -305
        ],
        [
          -4,
          -323
        ],
        [
          -81,
          -339
        ],
        [
          -180,
          -349
        ],
        [
          -290,
          -357
        ],
        [
          -378,
          -362
        ],
        [
          -419,
          -365
        ],
        [
          -419,
          -365
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        -419,
        -365
      ]
    },
    {
      "id": "OGleHfX3WpDaBnNohMeqI",
      "type": "freedraw",
      "x": 422,
      "y": 265.5,
      "width": 824,
      "height": 357,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 696003779,
      "version": 79,
      "versionNonce": 1802144547,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152213638,
      "link": null,
      "locked": false,
      "customData": {
        "order": 5
      },
      "points": [
        [
          0,
          0
        ],
        [
          -13,
          1
        ],
        [
          -25,
          2
        ],
        [
          -36,
          4
        ],
        [
          -52,
          6
        ],
        [
          -54,
          6
        ],
        [
          -38,
          6
        ],
        [
          -18,
          3
        ],
        [
          13,
          -4
        ],
        [
          74,
          -18
        ],
        [
          131,
          -26
        ],
        [
          161,
          -26
        ],
        [
          167,
          -23
        ],
        [
          168,
          -9
        ],
        [
          165,
          26
        ],
        [
          155,
          92
        ],
        [
          141,
          146
        ],
        [
          123,
          187
        ],
        [
          114,
          203
        ],
        [
          108,
          217
        ],
        [
          109,
          223
        ],
        [
          117,
          222
        ],
        [
          127,
          221
        ],
        [
          148,
          221
        ],
        [
          210,
          221
        ],
        [
          286,
          220
        ],
        [
          373,
          218
        ],
        [
          421,
          218
        ],
        [
          490,
          213
        ],
        [
          531,
          189
        ],
        [
          533,
          176
        ],
        [
          533,
          161
        ],
        [
          533,
          153
        ],
        [
          533,
          146
        ],
        [
          531,
          145
        ],
        [
          519,
          133
        ],
        [
          521,
          109
        ],
        [
          546,
          87
        ],
        [
          575,
          69
        ],
        [
          626,
          34
        ],
        [
          668,
          1
        ],
        [
          696,
          -21
        ],
        [
          698,
          -28
        ],
        [
          696,
          -29
        ],
        [
          689,
          -24
        ],
        [
          686,
          -11
        ],
        [
          688,
          5
        ],
        [
          701,
          27
        ],
        [
          726,
          70
        ],
        [
          741,
          117
        ],
        [
          740,
          159
        ],
        [
          719,
          200
        ],
        [
          690,
          239
        ],
        [
          664,
          271
        ],
        [
          644,
          293
        ],
        [
          631,
          311
        ],
        [
          624,
          320
        ],
        [
          619,
          328
        ],
        [
          620,
          328
        ],
        [
          642,
          317
        ],
        [
          675,
          294
        ],
        [
          718,
          257
        ],
        [
          744,
          229
        ],
        [
          769,
          159
        ],
        [
          770,
          112
        ],
        [
          762,
          72
        ],
        [
          750,
          52
        ],
        [
          729,
          34
        ],
        [
          691,
          28
        ],
        [
          666,
          30
        ],
        [
          652,
          31
        ],
        [
          639,
          32
        ],
        [
          629,
          32
        ],
        [
          623,
          28
        ],
        [
          617,
          22
        ],
        [
          613,
          13
        ],
        [
          622,
          -20
        ],
        [
          622,
          -20
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        622,
        -20
      ]
    },
    {
      "id": "69q_HBCc3jrut15iY6RYo",
      "type": "freedraw",
      "x": 1066,
      "y": 199.5,
      "width": 799,
      "height": 510,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 883318371,
      "version": 165,
      "versionNonce": 1429148141,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152216728,
      "link": null,
      "locked": false,
      "customData": {
        "order": 6
      },
      "points": [
        [
          0,
          0
        ],
        [
          1,
          -1
        ],
        [
          4,
          -3
        ],
        [
          9,
          -4
        ],
        [
          23,
          -7
        ],
        [
          31,
          -10
        ],
        [
          36,
          -11
        ],
        [
          40,
          -12
        ],
        [
          40,
          -11
        ],
        [
          41,
          4
        ],
        [
          46,
          25
        ],
        [
          54,
          41
        ],
        [
          70,
          66
        ],
        [
          90,
          94
        ],
        [
          95,
          105
        ],
        [
          95,
          119
        ],
        [
          93,
          139
        ],
        [
          90,
          167
        ],
        [
          88,
          208
        ],
        [
          88,
          227
        ],
        [
          96,
          264
        ],
        [
          104,
          303
        ],
        [
          122,
          364
        ],
        [
          131,
          384
        ],
        [
          141,
          404
        ],
        [
          145,
          413
        ],
        [
          143,
          419
        ],
        [
          133,
          425
        ],
        [
          124,
          427
        ],
        [
          121,
          428
        ],
        [
          121,
          429
        ],
        [
          121,
          430
        ],
        [
          125,
          431
        ],
        [
          128,
          431
        ],
        [
          132,
          431
        ],
        [
          142,
          430
        ],
        [
          156,
          427
        ],
        [
          178,
          420
        ],
        [
          208,
          410
        ],
        [
          236,
          393
        ],
        [
          242,
          368
        ],
        [
          239,
          333
        ],
        [
          225,
          279
        ],
        [
          207,
          218
        ],
        [
          183,
          166
        ],
        [
          174,
          154
        ],
        [
          168,
          148
        ],
        [
          168,
          147
        ],
        [
          167,
          147
        ],
        [
          167,
          143
        ],
        [
          167,
          142
        ],
        [
          167,
          136
        ],
        [
          168,
          129
        ],
        [
          168,
          114
        ],
        [
          167,
          102
        ],
        [
          166,
          90
        ],
        [
          166,
          76
        ],
        [
          174,
          47
        ],
        [
          183,
          33
        ],
        [
          192,
          18
        ],
        [
          198,
          9
        ],
        [
          200,
          2
        ],
        [
          199,
          -4
        ],
        [
          194,
          -7
        ],
        [
          179,
          -8
        ],
        [
          152,
          -9
        ],
        [
          114,
          -11
        ],
        [
          82,
          -15
        ],
        [
          61,
          -18
        ],
        [
          52,
          -21
        ],
        [
          47,
          -25
        ],
        [
          47,
          -30
        ],
        [
          48,
          -34
        ],
        [
          60,
          -42
        ],
        [
          72,
          -49
        ],
        [
          83,
          -55
        ],
        [
          87,
          -60
        ],
        [
          87,
          -61
        ],
        [
          84,
          -63
        ],
        [
          69,
          -65
        ],
        [
          34,
          -67
        ],
        [
          12,
          -68
        ],
        [
          -2,
          -70
        ],
        [
          -15,
          -72
        ],
        [
          -22,
          -75
        ],
        [
          -22,
          -77
        ],
        [
          -21,
          -77
        ],
        [
          -16,
          -78
        ],
        [
          -9,
          -79
        ],
        [
          -8,
          -78
        ],
        [
          -16,
          -75
        ],
        [
          -44,
          -70
        ],
        [
          -62,
          -66
        ],
        [
          -73,
          -63
        ],
        [
          -83,
          -61
        ],
        [
          -82,
          -60
        ],
        [
          -68,
          -60
        ],
        [
          -56,
          -59
        ],
        [
          -49,
          -56
        ],
        [
          -49,
          -53
        ],
        [
          -53,
          -42
        ],
        [
          -55,
          -36
        ],
        [
          -57,
          -28
        ],
        [
          -57,
          -24
        ],
        [
          -59,
          -10
        ],
        [
          -64,
          11
        ],
        [
          -70,
          28
        ],
        [
          -78,
          44
        ],
        [
          -85,
          52
        ],
        [
          -96,
          78
        ],
        [
          -103,
          100
        ],
        [
          -108,
          122
        ],
        [
          -110,
          133
        ],
        [
          -112,
          147
        ],
        [
          -111,
          159
        ],
        [
          -104,
          165
        ],
        [
          -95,
          168
        ],
        [
          -80,
          171
        ],
        [
          -53,
          171
        ],
        [
          -42,
          171
        ],
        [
          -34,
          171
        ],
        [
          -34,
          169
        ],
        [
          -41,
          169
        ],
        [
          -69,
          173
        ],
        [
          -92,
          176
        ],
        [
          -106,
          178
        ],
        [
          -125,
          182
        ],
        [
          -142,
          186
        ],
        [
          -150,
          187
        ],
        [
          -153,
          188
        ],
        [
          -149,
          186
        ],
        [
          -140,
          181
        ],
        [
          -133,
          175
        ],
        [
          -135,
          182
        ],
        [
          -156,
          219
        ],
        [
          -191,
          258
        ],
        [
          -253,
          306
        ],
        [
          -260,
          311
        ],
        [
          -321,
          346
        ],
        [
          -356,
          367
        ],
        [
          -381,
          382
        ],
        [
          -400,
          392
        ],
        [
          -405,
          394
        ],
        [
          -405,
          388
        ],
        [
          -400,
          373
        ],
        [
          -389,
          347
        ],
        [
          -375,
          329
        ],
        [
          -354,
          308
        ],
        [
          -323,
          277
        ],
        [
          -303,
          257
        ],
        [
          -282,
          215
        ],
        [
          -286,
          196
        ],
        [
          -307,
          181
        ],
        [
          -324,
          176
        ],
        [
          -367,
          165
        ],
        [
          -410,
          155
        ],
        [
          -459,
          141
        ],
        [
          -511,
          127
        ],
        [
          -533,
          118
        ],
        [
          -556,
          100
        ],
        [
          -557,
          93
        ],
        [
          -556,
          82
        ],
        [
          -550,
          72
        ],
        [
          -548,
          66
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        -548,
        66
      ]
    },
    {
      "id": "Ru_kMLn6ywpdJ7IIclE67",
      "type": "freedraw",
      "x": 292,
      "y": 374.5,
      "width": 181,
      "height": 234,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 349911725,
      "version": 32,
      "versionNonce": 483579981,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152217448,
      "link": null,
      "locked": false,
      "customData": {
        "order": 7
      },
      "points": [
        [
          0,
          0
        ],
        [
          -2,
          4
        ],
        [
          -9,
          14
        ],
        [
          -17,
          33
        ],
        [
          -18,
          51
        ],
        [
          -16,
          67
        ],
        [
          -3,
          81
        ],
        [
          20,
          94
        ],
        [
          43,
          100
        ],
        [
          67,
          101
        ],
        [
          95,
          98
        ],
        [
          117,
          93
        ],
        [
          157,
          87
        ],
        [
          163,
          87
        ],
        [
          157,
          87
        ],
        [
          143,
          87
        ],
        [
          117,
          87
        ],
        [
          82,
          87
        ],
        [
          58,
          88
        ],
        [
          45,
          90
        ],
        [
          38,
          93
        ],
        [
          44,
          120
        ],
        [
          55,
          151
        ],
        [
          60,
          174
        ],
        [
          60,
          201
        ],
        [
          53,
          219
        ],
        [
          45,
          230
        ],
        [
          39,
          234
        ],
        [
          38,
          232
        ],
        [
          38,
          217
        ],
        [
          38,
          217
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        38,
        217
      ]
    },
    {
      "id": "xXtxTsARoOoE0IzxaMNog",
      "type": "freedraw",
      "x": 365,
      "y": 478.5,
      "width": 580,
      "height": 215,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 2018044173,
      "version": 46,
      "versionNonce": 1774047587,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152218370,
      "link": null,
      "locked": false,
      "customData": {
        "order": 8
      },
      "points": [
        [
          0,
          0
        ],
        [
          12,
          -8
        ],
        [
          28,
          -17
        ],
        [
          54,
          -28
        ],
        [
          108,
          -53
        ],
        [
          159,
          -71
        ],
        [
          204,
          -87
        ],
        [
          247,
          -103
        ],
        [
          304,
          -121
        ],
        [
          366,
          -134
        ],
        [
          427,
          -140
        ],
        [
          475,
          -144
        ],
        [
          506,
          -147
        ],
        [
          522,
          -147
        ],
        [
          536,
          -149
        ],
        [
          543,
          -155
        ],
        [
          541,
          -163
        ],
        [
          535,
          -168
        ],
        [
          522,
          -176
        ],
        [
          505,
          -186
        ],
        [
          497,
          -190
        ],
        [
          494,
          -191
        ],
        [
          480,
          -191
        ],
        [
          455,
          -191
        ],
        [
          446,
          -191
        ],
        [
          440,
          -183
        ],
        [
          443,
          -150
        ],
        [
          450,
          -114
        ],
        [
          457,
          -90
        ],
        [
          461,
          -65
        ],
        [
          461,
          -44
        ],
        [
          446,
          -13
        ],
        [
          431,
          2
        ],
        [
          411,
          17
        ],
        [
          401,
          24
        ],
        [
          401,
          23
        ],
        [
          414,
          13
        ],
        [
          436,
          -3
        ],
        [
          458,
          -17
        ],
        [
          487,
          -35
        ],
        [
          520,
          -53
        ],
        [
          555,
          -72
        ],
        [
          572,
          -82
        ],
        [
          580,
          -106
        ],
        [
          580,
          -106
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        580,
        -106
      ]
    },
    {
      "id": "VbOsoX6-ffkpNXYb0Cdwm",
      "type": "freedraw",
      "x": 949,
      "y": 109.5,
      "width": 1463,
      "height": 753,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 1811167747,
      "version": 332,
      "versionNonce": 1069258467,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152228464,
      "link": null,
      "locked": false,
      "customData": {
        "order": 9
      },
      "points": [
        [
          0,
          0
        ],
        [
          8,
          -12
        ],
        [
          13,
          -18
        ],
        [
          22,
          -23
        ],
        [
          25,
          -19
        ],
        [
          25,
          -4
        ],
        [
          22,
          15
        ],
        [
          5,
          46
        ],
        [
          -31,
          93
        ],
        [
          -90,
          163
        ],
        [
          -153,
          236
        ],
        [
          -198,
          292
        ],
        [
          -220,
          323
        ],
        [
          -231,
          343
        ],
        [
          -234,
          349
        ],
        [
          -233,
          354
        ],
        [
          -220,
          350
        ],
        [
          -201,
          334
        ],
        [
          -174,
          303
        ],
        [
          -155,
          276
        ],
        [
          -124,
          221
        ],
        [
          -113,
          197
        ],
        [
          -108,
          186
        ],
        [
          -104,
          173
        ],
        [
          -107,
          169
        ],
        [
          -124,
          165
        ],
        [
          -145,
          176
        ],
        [
          -168,
          193
        ],
        [
          -211,
          226
        ],
        [
          -287,
          277
        ],
        [
          -330,
          303
        ],
        [
          -353,
          318
        ],
        [
          -366,
          329
        ],
        [
          -366,
          333
        ],
        [
          -347,
          329
        ],
        [
          -336,
          324
        ],
        [
          -327,
          317
        ],
        [
          -325,
          316
        ],
        [
          -334,
          316
        ],
        [
          -393,
          328
        ],
        [
          -502,
          348
        ],
        [
          -741,
          402
        ],
        [
          -886,
          434
        ],
        [
          -947,
          447
        ],
        [
          -979,
          453
        ],
        [
          -980,
          450
        ],
        [
          -964,
          437
        ],
        [
          -951,
          425
        ],
        [
          -942,
          418
        ],
        [
          -939,
          415
        ],
        [
          -937,
          414
        ],
        [
          -929,
          412
        ],
        [
          -898,
          402
        ],
        [
          -821,
          376
        ],
        [
          -687,
          326
        ],
        [
          -628,
          303
        ],
        [
          -548,
          275
        ],
        [
          -485,
          263
        ],
        [
          -453,
          262
        ],
        [
          -455,
          263
        ],
        [
          -482,
          270
        ],
        [
          -550,
          280
        ],
        [
          -632,
          296
        ],
        [
          -709,
          319
        ],
        [
          -769,
          338
        ],
        [
          -807,
          347
        ],
        [
          -816,
          350
        ],
        [
          -811,
          349
        ],
        [
          -797,
          346
        ],
        [
          -745,
          337
        ],
        [
          -681,
          332
        ],
        [
          -639,
          327
        ],
        [
          -555,
          318
        ],
        [
          -518,
          314
        ],
        [
          -505,
          313
        ],
        [
          -498,
          312
        ],
        [
          -493,
          308
        ],
        [
          -488,
          305
        ],
        [
          -482,
          297
        ],
        [
          -479,
          284
        ],
        [
          -480,
          267
        ],
        [
          -513,
          232
        ],
        [
          -562,
          200
        ],
        [
          -617,
          170
        ],
        [
          -648,
          154
        ],
        [
          -698,
          123
        ],
        [
          -703,
          114
        ],
        [
          -701,
          108
        ],
        [
          -665,
          112
        ],
        [
          -612,
          131
        ],
        [
          -552,
          149
        ],
        [
          -519,
          158
        ],
        [
          -477,
          167
        ],
        [
          -447,
          170
        ],
        [
          -430,
          171
        ],
        [
          -423,
          169
        ],
        [
          -398,
          141
        ],
        [
          -370,
          125
        ],
        [
          -346,
          115
        ],
        [
          -328,
          114
        ],
        [
          -289,
          132
        ],
        [
          -256,
          145
        ],
        [
          -182,
          170
        ],
        [
          -104,
          192
        ],
        [
          -69,
          201
        ],
        [
          -10,
          211
        ],
        [
          11,
          213
        ],
        [
          17,
          213
        ],
        [
          17,
          215
        ],
        [
          13,
          219
        ],
        [
          11,
          237
        ],
        [
          29,
          265
        ],
        [
          142,
          353
        ],
        [
          251,
          435
        ],
        [
          311,
          492
        ],
        [
          356,
          569
        ],
        [
          359,
          595
        ],
        [
          336,
          655
        ],
        [
          319,
          672
        ],
        [
          294,
          689
        ],
        [
          255,
          696
        ],
        [
          239,
          687
        ],
        [
          196,
          647
        ],
        [
          171,
          624
        ],
        [
          158,
          611
        ],
        [
          158,
          605
        ],
        [
          158,
          598
        ],
        [
          148,
          585
        ],
        [
          117,
          563
        ],
        [
          42,
          527
        ],
        [
          -41,
          508
        ],
        [
          -132,
          499
        ],
        [
          -199,
          494
        ],
        [
          -221,
          490
        ],
        [
          -230,
          485
        ],
        [
          -227,
          478
        ],
        [
          -223,
          473
        ],
        [
          -223,
          474
        ],
        [
          -248,
          496
        ],
        [
          -297,
          520
        ],
        [
          -372,
          547
        ],
        [
          -459,
          573
        ],
        [
          -533,
          600
        ],
        [
          -574,
          626
        ],
        [
          -586,
          638
        ],
        [
          -587,
          643
        ],
        [
          -578,
          647
        ],
        [
          -557,
          644
        ],
        [
          -537,
          633
        ],
        [
          -519,
          618
        ],
        [
          -511,
          607
        ],
        [
          -510,
          594
        ],
        [
          -523,
          584
        ],
        [
          -571,
          568
        ],
        [
          -603,
          559
        ],
        [
          -625,
          555
        ],
        [
          -655,
          549
        ],
        [
          -688,
          538
        ],
        [
          -697,
          532
        ],
        [
          -704,
          522
        ],
        [
          -704,
          512
        ],
        [
          -699,
          496
        ],
        [
          -672,
          467
        ],
        [
          -657,
          455
        ],
        [
          -637,
          442
        ],
        [
          -624,
          432
        ],
        [
          -619,
          418
        ],
        [
          -628,
          406
        ],
        [
          -653,
          398
        ],
        [
          -691,
          395
        ],
        [
          -738,
          395
        ],
        [
          -782,
          396
        ],
        [
          -809,
          396
        ],
        [
          -826,
          396
        ],
        [
          -833,
          394
        ],
        [
          -838,
          391
        ],
        [
          -838,
          388
        ],
        [
          -837,
          386
        ],
        [
          -830,
          382
        ],
        [
          -816,
          378
        ],
        [
          -783,
          376
        ],
        [
          -768,
          376
        ],
        [
          -737,
          382
        ],
        [
          -699,
          393
        ],
        [
          -661,
          414
        ],
        [
          -632,
          449
        ],
        [
          -598,
          503
        ],
        [
          -567,
          548
        ],
        [
          -556,
          564
        ],
        [
          -552,
          565
        ],
        [
          -552,
          557
        ],
        [
          -537,
          502
        ],
        [
          -519,
          466
        ],
        [
          -481,
          397
        ],
        [
          -441,
          337
        ],
        [
          -408,
          295
        ],
        [
          -366,
          260
        ],
        [
          -318,
          233
        ],
        [
          -276,
          224
        ],
        [
          -245,
          229
        ],
        [
          -229,
          254
        ],
        [
          -228,
          279
        ],
        [
          -234,
          307
        ],
        [
          -246,
          339
        ],
        [
          -256,
          367
        ],
        [
          -305,
          487
        ],
        [
          -355,
          567
        ],
        [
          -384,
          603
        ],
        [
          -405,
          628
        ],
        [
          -410,
          639
        ],
        [
          -404,
          638
        ],
        [
          -380,
          621
        ],
        [
          -356,
          599
        ],
        [
          -304,
          549
        ],
        [
          -220,
          436
        ],
        [
          -176,
          366
        ],
        [
          -150,
          340
        ],
        [
          -114,
          321
        ],
        [
          -93,
          315
        ],
        [
          -86,
          314
        ],
        [
          -87,
          314
        ],
        [
          -90,
          314
        ],
        [
          -109,
          316
        ],
        [
          -139,
          320
        ],
        [
          -266,
          331
        ],
        [
          -342,
          343
        ],
        [
          -382,
          349
        ],
        [
          -422,
          350
        ],
        [
          -426,
          346
        ],
        [
          -426,
          344
        ],
        [
          -413,
          329
        ],
        [
          -382,
          294
        ],
        [
          -296,
          212
        ],
        [
          -236,
          160
        ],
        [
          -206,
          135
        ],
        [
          -187,
          115
        ],
        [
          -184,
          99
        ],
        [
          -202,
          92
        ],
        [
          -237,
          87
        ],
        [
          -270,
          84
        ],
        [
          -326,
          81
        ],
        [
          -421,
          80
        ],
        [
          -487,
          78
        ],
        [
          -519,
          77
        ],
        [
          -548,
          74
        ],
        [
          -560,
          72
        ],
        [
          -558,
          70
        ],
        [
          -549,
          68
        ],
        [
          -508,
          67
        ],
        [
          -453,
          68
        ],
        [
          -376,
          73
        ],
        [
          -333,
          77
        ],
        [
          -281,
          85
        ],
        [
          -267,
          89
        ],
        [
          -269,
          94
        ],
        [
          -295,
          103
        ],
        [
          -344,
          111
        ],
        [
          -417,
          119
        ],
        [
          -497,
          123
        ],
        [
          -563,
          124
        ],
        [
          -591,
          124
        ],
        [
          -596,
          123
        ],
        [
          -588,
          118
        ],
        [
          -546,
          111
        ],
        [
          -482,
          106
        ],
        [
          -400,
          103
        ],
        [
          -310,
          101
        ],
        [
          -251,
          99
        ],
        [
          -138,
          97
        ],
        [
          -77,
          94
        ],
        [
          -32,
          91
        ],
        [
          -13,
          90
        ],
        [
          5,
          88
        ],
        [
          7,
          87
        ],
        [
          7,
          86
        ],
        [
          1,
          86
        ],
        [
          -5,
          86
        ],
        [
          -8,
          85
        ],
        [
          -18,
          72
        ],
        [
          -24,
          55
        ],
        [
          -23,
          37
        ],
        [
          -9,
          8
        ],
        [
          9,
          -17
        ],
        [
          30,
          -40
        ],
        [
          54,
          -54
        ],
        [
          69,
          -57
        ],
        [
          92,
          -52
        ],
        [
          99,
          -36
        ],
        [
          99,
          -16
        ],
        [
          98,
          9
        ],
        [
          89,
          49
        ],
        [
          79,
          82
        ],
        [
          74,
          113
        ],
        [
          74,
          126
        ],
        [
          79,
          145
        ],
        [
          116,
          206
        ],
        [
          151,
          251
        ],
        [
          180,
          292
        ],
        [
          191,
          313
        ],
        [
          199,
          342
        ],
        [
          199,
          350
        ],
        [
          202,
          360
        ],
        [
          209,
          360
        ],
        [
          213,
          360
        ],
        [
          237,
          345
        ],
        [
          269,
          323
        ],
        [
          298,
          303
        ],
        [
          340,
          270
        ],
        [
          400,
          219
        ],
        [
          438,
          192
        ],
        [
          462,
          176
        ],
        [
          481,
          163
        ],
        [
          483,
          157
        ],
        [
          460,
          150
        ],
        [
          438,
          147
        ],
        [
          389,
          143
        ],
        [
          320,
          140
        ],
        [
          203,
          139
        ],
        [
          160,
          143
        ],
        [
          125,
          154
        ],
        [
          123,
          157
        ],
        [
          121,
          160
        ],
        [
          117,
          174
        ],
        [
          101,
          196
        ],
        [
          84,
          217
        ],
        [
          75,
          229
        ],
        [
          51,
          256
        ],
        [
          21,
          288
        ],
        [
          12,
          297
        ],
        [
          -3,
          316
        ],
        [
          -3,
          316
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        -3,
        316
      ]
    },
    {
      "id": "4MUgOdL8DjywSWtJh9VxT",
      "type": "freedraw",
      "x": 924,
      "y": 387.5,
      "width": 140,
      "height": 378,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 930667309,
      "version": 22,
      "versionNonce": 2070086925,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152228975,
      "link": null,
      "locked": false,
      "customData": {
        "order": 10
      },
      "points": [
        [
          0,
          0
        ],
        [
          9,
          -19
        ],
        [
          27,
          -44
        ],
        [
          98,
          -130
        ],
        [
          131,
          -181
        ],
        [
          139,
          -207
        ],
        [
          140,
          -228
        ],
        [
          134,
          -239
        ],
        [
          111,
          -237
        ],
        [
          100,
          -226
        ],
        [
          87,
          -202
        ],
        [
          76,
          -177
        ],
        [
          72,
          -141
        ],
        [
          72,
          -120
        ],
        [
          81,
          -84
        ],
        [
          96,
          -39
        ],
        [
          107,
          -3
        ],
        [
          108,
          35
        ],
        [
          101,
          83
        ],
        [
          87,
          139
        ],
        [
          87,
          139
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        87,
        139
      ]
    },
    {
      "id": "wnsIhkA1cFoRmFHLZV_kd",
      "type": "freedraw",
      "x": 877,
      "y": 599.5,
      "width": 417,
      "height": 372,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 214230477,
      "version": 30,
      "versionNonce": 659222189,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152229605,
      "link": null,
      "locked": false,
      "customData": {
        "order": 11
      },
      "points": [
        [
          0,
          0
        ],
        [
          -19,
          0
        ],
        [
          -36,
          0
        ],
        [
          -42,
          0
        ],
        [
          -70,
          0
        ],
        [
          -104,
          3
        ],
        [
          -112,
          3
        ],
        [
          -122,
          3
        ],
        [
          -123,
          2
        ],
        [
          -114,
          -17
        ],
        [
          -71,
          -62
        ],
        [
          18,
          -138
        ],
        [
          80,
          -175
        ],
        [
          154,
          -202
        ],
        [
          227,
          -228
        ],
        [
          244,
          -238
        ],
        [
          255,
          -248
        ],
        [
          255,
          -258
        ],
        [
          214,
          -287
        ],
        [
          174,
          -313
        ],
        [
          90,
          -345
        ],
        [
          -13,
          -362
        ],
        [
          -103,
          -366
        ],
        [
          -155,
          -368
        ],
        [
          -162,
          -369
        ],
        [
          -158,
          -369
        ],
        [
          -138,
          -369
        ],
        [
          -119,
          -369
        ],
        [
          -119,
          -369
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        -119,
        -369
      ]
    },
    {
      "id": "qJLgbgdgwSZ_GSbEp-mzy",
      "type": "freedraw",
      "x": 759,
      "y": 220.5,
      "width": 93,
      "height": 27,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 297199469,
      "version": 12,
      "versionNonce": 1318511139,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152229981,
      "link": null,
      "locked": false,
      "customData": {
        "order": 12
      },
      "points": [
        [
          0,
          0
        ],
        [
          -3,
          -3
        ],
        [
          -8,
          -7
        ],
        [
          -11,
          -10
        ],
        [
          -16,
          -14
        ],
        [
          -22,
          -14
        ],
        [
          -31,
          -14
        ],
        [
          -46,
          -14
        ],
        [
          -67,
          -17
        ],
        [
          -93,
          -27
        ],
        [
          -93,
          -27
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        -93,
        -27
      ]
    },
    {
      "id": "twVmryMsKvTo3U3vEUADz",
      "type": "diamond",
      "x": 720,
      "y": 200,
      "width": 200,
      "height": 220,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": {
        "type": 2
      },
      "seed": 1800783437,
      "version": 9,
      "versionNonce": 1554049357,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152230916,
      "link": null,
      "locked": false,
      "customData": {
        "order": 13
      }
    },
    {
      "id": "417jtWjkgEPhFHX0UWzSH",
      "type": "ellipse",
      "x": 660,
      "y": 160,
      "width": 140,
      "height": 360,
      "angle": 0,
      "strokeColor": "#1e1e1e",
      "backgroundColor": "transparent",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": {
        "type": 2
      },
      "seed": 1988540941,
      "version": 7,
      "versionNonce": 1180240973,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152231832,
      "link": null,
      "locked": false,
      "customData": {
        "order": 14
      }
    },
    {
      "id": "waSf8x-LieY57_kNahcKJ",
      "type": "rectangle",
      "x": 880,
      "y": 420,
      "width": 280,
      "height": 280,
      "angle": 0,
      "strokeColor": "#1971c2",
      "backgroundColor": "#ffec99",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 2,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": {
        "type": 3
      },
      "seed": 1746975203,
      "version": 36,
      "versionNonce": 1250157549,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152238555,
      "link": null,
      "locked": false,
      "customData": {
        "order": 15
      }
    },
    {
      "id": "wng041c0NTdXXiPPNaXkU",
      "type": "arrow",
      "x": 880,
      "y": 80,
      "width": 540,
      "height": 360,
      "angle": 0,
      "strokeColor": "#f08c00",
      "backgroundColor": "#ffec99",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": {
        "type": 2
      },
      "seed": 616083267,
      "version": 57,
      "versionNonce": 206563277,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152255728,
      "link": null,
      "locked": false,
      "customData": {
        "order": 16
      },
      "points": [
        [
          0,
          0
        ],
        [
          -540,
          80
        ],
        [
          -260,
          360
        ]
      ],
      "lastCommittedPoint": null,
      "startBinding": null,
      "endBinding": null,
      "startArrowhead": "bar",
      "endArrowhead": "bar"
    },
    {
      "id": "qc2Lw9BGW_0HTEiAOYJqU",
      "type": "freedraw",
      "x": 823,
      "y": 124.5,
      "width": 344,
      "height": 284,
      "angle": 0,
      "strokeColor": "#f08c00",
      "backgroundColor": "#ffec99",
      "fillStyle": "solid",
      "strokeWidth": 2,
      "strokeStyle": "solid",
      "roughness": 1,
      "opacity": 100,
      "groupIds": [],
      "frameId": null,
      "roundness": null,
      "seed": 543692941,
      "version": 76,
      "versionNonce": 614425869,
      "isDeleted": false,
      "boundElements": null,
      "updated": 1729152258690,
      "link": null,
      "locked": false,
      "customData": {
        "order": 17
      },
      "points": [
        [
          0,
          0
        ],
        [
          2,
          7
        ],
        [
          3,
          8
        ],
        [
          8,
          18
        ],
        [
          17,
          29
        ],
        [
          27,
          42
        ],
        [
          40,
          56
        ],
        [
          49,
          66
        ],
        [
          67,
          86
        ],
        [
          78,
          102
        ],
        [
          92,
          117
        ],
        [
          103,
          127
        ],
        [
          118,
          137
        ],
        [
          128,
          146
        ],
        [
          131,
          155
        ],
        [
          125,
          160
        ],
        [
          112,
          167
        ],
        [
          89,
          179
        ],
        [
          80,
          184
        ],
        [
          71,
          189
        ],
        [
          65,
          189
        ],
        [
          58,
          189
        ],
        [
          51,
          185
        ],
        [
          43,
          180
        ],
        [
          43,
          179
        ],
        [
          44,
          179
        ],
        [
          53,
          179
        ],
        [
          57,
          180
        ],
        [
          62,
          181
        ],
        [
          63,
          183
        ],
        [
          62,
          186
        ],
        [
          60,
          188
        ],
        [
          58,
          188
        ],
        [
          57,
          188
        ],
        [
          55,
          187
        ],
        [
          53,
          185
        ],
        [
          49,
          181
        ],
        [
          48,
          179
        ],
        [
          47,
          172
        ],
        [
          47,
          162
        ],
        [
          49,
          154
        ],
        [
          52,
          142
        ],
        [
          54,
          132
        ],
        [
          51,
          132
        ],
        [
          44,
          136
        ],
        [
          29,
          143
        ],
        [
          13,
          148
        ],
        [
          -6,
          151
        ],
        [
          -52,
          156
        ],
        [
          -77,
          157
        ],
        [
          -116,
          158
        ],
        [
          -151,
          160
        ],
        [
          -180,
          158
        ],
        [
          -195,
          149
        ],
        [
          -202,
          139
        ],
        [
          -203,
          134
        ],
        [
          -204,
          134
        ],
        [
          -205,
          143
        ],
        [
          -207,
          167
        ],
        [
          -211,
          211
        ],
        [
          -213,
          228
        ],
        [
          -213,
          244
        ],
        [
          -212,
          256
        ],
        [
          -209,
          262
        ],
        [
          -202,
          270
        ],
        [
          -194,
          276
        ],
        [
          -180,
          281
        ],
        [
          -167,
          284
        ],
        [
          -140,
          283
        ],
        [
          -129,
          274
        ],
        [
          -122,
          261
        ],
        [
          -118,
          252
        ],
        [
          -110,
          235
        ],
        [
          -108,
          232
        ],
        [
          -107,
          231
        ]
      ],
      "pressures": [],
      "simulatePressure": true,
      "lastCommittedPoint": [
        -107,
        231
      ]
    }
  ],
  "appState": {
    "gridSize": 20,
    "viewBackgroundColor": "#ffffff"
  },
  "files": {}
}
""";
}
