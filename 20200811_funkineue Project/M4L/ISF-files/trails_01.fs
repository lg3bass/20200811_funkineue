/*
{
  "CATEGORIES" : [
    "XXX"
  ],
  "CREDIT": "",
  "ISFVSN" : "2",
  "INPUTS" : [
    {
      "NAME" : "width",
      "TYPE" : "float",
      "DEFAULT" : 0.25
    },
    {
      "NAME" : "offset",
      "TYPE" : "point2D",
      "DEFAULT" : [
        0,
        0
      ],
      "MIN" : [
      	0,
      	0
      ],
      "MAX" : [
      	1,
      	1
      ]
    },
    {
      "NAME" : "color1",
      "TYPE" : "color",
      "DEFAULT" : [
        1,
        1,
        1,
        1
      ]
    },
    {
      "NAME" : "color2",
      "TYPE" : "color",
      "DEFAULT" : [
        0,
        0,
        0,
        1
      ]
    },
    {
      "NAME" : "splitPos",
      "TYPE" : "point2D",
      "MAX" : [
        1,
        1
      ],
      "DEFAULT" : [
        0.5,
        0.5
      ],
      "MIN" : [
        0,
        0
      ]
    }
  ]
}
*/


float circle(vec2 centre, float radius, vec2 fragCoord)
{
    vec2 delta = fragCoord - centre;
    float dist = length(delta);

    if ( dist < radius )
    {
        return 1.0 - (dist/radius);
    }
    else
    {
        return -1.0;
    }
    
}

void main()
{
    vec2 centre = RENDERSIZE.xy * 0.5;
    float speed = 2.0;
    centre += centre * 0.8 * vec2(sin(TIME * 0.3 * speed) * cos(TIME * 0.7 * speed),
                                  sin(TIME * 1.3 * speed) * cos(TIME * 1.9 * speed));
    
    float radius = 15.0 + 10.0 * sin(TIME * 3.0) * cos(TIME * 7.0);
    
    float circ = circle(centre, radius, gl_FragCoord.xy);
    
    vec4 outColor;
    
    if ( circ >= 0.0 ) {
        float scale = 0.1;
        
        float r = ((sin(TIME * 3.0 * scale) * cos(TIME * 7.0 * scale)) + 1.0) - 0.5;
        float g = ((sin(TIME * 13.0 * scale) * cos(TIME * 17.0 * scale)) + 1.0) - 0.5;
        float b = ((sin(TIME * 19.0 * scale) * cos(TIME * 3.0 * scale)) + 1.0) - 0.5;

        gl_FragColor = vec4(((circ * 0.25) + 0.75)*vec3(r,g,b),1.0);
    } else {
        discard;
    }
}