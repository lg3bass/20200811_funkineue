/*{
    "CATEGORIES": [
        "XXX"
    ],
    "CREDIT": "",
    "INPUTS": [
        {
            "DEFAULT": [
                0.39215686274509803,
                0.058823529411764705,
                0.06274509803921569,
                1
            ],
            "LABEL": "color1",
            "NAME": "color1",
            "TYPE": "color"
        },
        {
            "DEFAULT": [
                0.12941176470588237,
                0.09803921568627451,
                0.39215686274509803,
                1
            ],
            "LABEL": "color2",
            "NAME": "color2",
            "TYPE": "color"
        },
        {
            "DEFAULT": 0.035,
            "LABEL": "radius",
            "MAX": 1,
            "MIN": 0,
            "NAME": "radius01",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.7,
            "LABEL": "tailLength",
            "MAX": 1,
            "MIN": 0,
            "NAME": "tailLength01",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.03,
            "LABEL": "edgeWidth",
            "NAME": "edgeWidth01",
            "TYPE": "float"
        },
        {
            "DEFAULT": 11,
            "LABEL": "numberOfElements",
            "LABELS": [
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12"
            ],
            "NAME": "numElements",
            "TYPE": "long",
            "VALUES": [
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12
            ]
        }
    ],
    "ISFVSN": "2"
}
*/


vec2 thingPosition(float t, float aspect) {
    float tx = t / aspect;
    
    //change these numbers to make the pattern different
    vec2 p = vec2(sin(2.2 * tx) - cos(1.4 * tx), cos(1.3 * t) + sin(-1.9 * t));
    
    //size of the cloud
    p.y *= 0.2;
    p.x *= 0.2;
 	return p;
}

void main()
{
	vec2 uv = vec2(0.5) - gl_FragCoord.xy / RENDERSIZE.xy;
    float aspect = RENDERSIZE.x / RENDERSIZE.y;
    uv.x *= aspect;
    vec3 cFinal = vec3(0.0);
    
    float radius = 0.1;
    
    //taillength array
    float tailLength = tailLength01;
    
    //edgewidth array
    float edgeWidth = edgeWidth01;
    
    
    for (int j = 0; j < numElements; j++) {
        float thisRadius = radius + sin(float(j) * 0.7 + TIME * 1.2) * 0.02;
        
        //radius array
        thisRadius *= radius01;
        
        float dMin = 1.0;
        const int iMax = 12;
        for (int i = 0; i < iMax; i++) {
            float iPct = float(i) / float(iMax);
            float segmentDistance = length(thingPosition(TIME * 2.0 + float(j) * 1.5 - iPct * tailLength, aspect) - uv);
            dMin = min(dMin, segmentDistance + pow(iPct, 0.8) * (thisRadius + edgeWidth));
        }
        cFinal += 5.0 * (1.0 - smoothstep(thisRadius, thisRadius + edgeWidth, dMin)) * mix(color1.rgb, color2.rgb, mod(float(j), 2.0));
    }
    
    vec3 outColor = vec3(1.0) - cFinal;
    outColor = cFinal;
    
	gl_FragColor = vec4(outColor, 1.0);
}