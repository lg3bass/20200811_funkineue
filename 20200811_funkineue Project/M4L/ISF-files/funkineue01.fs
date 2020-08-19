/*{
    "CATEGORIES": [
        "Automatically Converted",
        "Shadertoy"
    ],
    "DESCRIPTION": "Automatically converted from https://www.shadertoy.com/view/MsVXWD by JasonD.  Fixed version of https://www.shadertoy.com/view/XsS3DV",
    "IMPORTED": {
    },
    "INPUTS": [
        {
            "NAME": "iMouse",
            "TYPE": "point2D"
        },
        {
            "NAME": "fftImage",
            "TYPE": "audioFFT"
        },
        {
            "DEFAULT": 0,
            "MAX": 1,
            "MIN": 0,
            "NAME": "ADSR",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0,
            "LABEL": "testing mode",
            "LABELS": [
                "editor",
                "m4l"
            ],
            "NAME": "mode",
            "TYPE": "long",
            "VALUES": [
                0,
                1
            ]
        },
                {
            "DEFAULT": 0,
            "LABEL": "animated",
            "LABELS": [
                "time",
                "slider"
            ],
            "NAME": "animated",
            "TYPE": "long",
            "VALUES": [
                0,
                1
            ]
        },
        {
            "DEFAULT": 4,
            "LABEL": "grid dimensions",
            "LABELS": [
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16"
            ],
            "MAX": 16,
            "MIN": 4,
            "NAME": "elements1",
            "TYPE": "long",
            "VALUES": [
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13,
                14,
                15,
                16
            ]
        },
        {
            "DEFAULT": 4,
            "LABEL": "grid dimensions",
            "LABELS": [
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16"
            ],
            "MAX": 16,
            "MIN": 4,
            "NAME": "elements2",
            "TYPE": "long",
            "VALUES": [
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13,
                14,
                15,
                16
            ]
        },
        {
            "DEFAULT": 4,
            "LABEL": "grid dimensions",
            "LABELS": [
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16"
            ],
            "MAX": 16,
            "MIN": 4,
            "NAME": "elements3",
            "TYPE": "long",
            "VALUES": [
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13,
                14,
                15,
                16
            ]
        },
        {
            "DEFAULT": 4,
            "LABEL": "grid dimensions",
            "LABELS": [
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16"
            ],
            "MAX": 16,
            "MIN": 4,
            "NAME": "elements4",
            "TYPE": "long",
            "VALUES": [
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13,
                14,
                15,
                16
            ]
        },
        {
            "DEFAULT": 0.35,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "outside1",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.3,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "inside1",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.5,
            "MAX": 0.7,
            "MIN": 0.0,
            "NAME": "arclen1",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0,
            "MAX": 360,
            "MIN": 0,
            "NAME": "layerAngle1",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0,
            "MAX": 360,
            "MIN": 0,
            "NAME": "layerAngle2",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0,
            "MAX": 360,
            "MIN": 0,
            "NAME": "layerAngle3",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0,
            "MAX": 360,
            "MIN": 0,
            "NAME": "layerAngle4",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0,
            "MAX": 360,
            "MIN": 0,
            "NAME": "globalOrient",
            "TYPE": "float"
        },
        {
            "DEFAULT": true,
            "LABEL": "layer1",
            "NAME": "layer1enabled",
            "TYPE": "bool"
        },
        {
            "DEFAULT": false,
            "LABEL": "layer2",
            "NAME": "layer2enabled",
            "TYPE": "bool"
        },
        {
            "DEFAULT": false,
            "LABEL": "layer3",
            "NAME": "layer3enabled",
            "TYPE": "bool"
        },
        {
            "DEFAULT": false,
            "LABEL": "layer4",
            "NAME": "layer4enabled",
            "TYPE": "bool"
        },
        {
            "LABEL": "c1",
            "NAME": "c1",
            "TYPE": "color"
        }
    ],
    "ISFVSN": "2"
}
*/

#define CNT 16
#define PI 3.1459265358979
#define TAU PI * 2.0

// COLORS

#define WHITE vec3(1.0, 1.0, 1.0)
#define SWEETPEA vec3(1.0, 0.7, 0.75)
#define BLUE vec3(0.250, 0.215, 0.964)
#define REDORANGE vec3(0.964, 0.360, 0.215)
#define YELLOW vec3(0.972, 0.878, 0.125)

#define MediumOrchid vec3(0.729, 0.333, 0.827)
#define Lavender vec3(0.902, 0.902, 0.980)
#define PaleGoldenrod vec3(0.933, 0.910, 0.667)
#define DarkSalmon vec3(0.914, 0.588, 0.478)

float linearstep(float begin, float end, float t) {
    return clamp((t - begin) / (end - begin), 0.0, 1.0);
}


float stroke(float x, float s, float w){
	float d = step(s, x+w * 0.5) - step(s, x - w * 0.5);
	return clamp(d,0.0,1.0);
	}
	
float smoothStroke(float x, float s, float w){
	//float d = step(s, x+w * 0.5) - step(s, x - w * 0.5);
	float d = smoothstep( x-w*2.,x+w*2.,s);
	//return d;
	return clamp(d,0.0,1.0);
	}
	
float circleSDF(vec2 pos, vec2 st){
	
	float s = st.x - pos.x;
	float t = st.y - pos.y;
	vec2 origin = vec2(s,t);
	
	float f = length(origin)*2.;
	
	return f;
}


float fill(float x, float size){
	return 1.0 - step(size, x);
}

float rectSDF(vec2 st, vec2 s){
	st = st*2.0 -1.0;
	return max(abs(st.x/s.x),abs(st.y/s.y));	
}

float triSDF(vec2 st){
	st = (st * 2.0 - 1.0 ) * 2.0;
	return max(abs(st.x) * 0.866025 + st.y * 0.5 , - st.y * 0.5);
}

float hexSDF(vec2 st){
	st = abs(st*2.0 - 1.0);
	return max(abs(st.y), st.x * 0.866025 + st.y * 0.5);
}

float map(float n, float i1, float i2, float o1, float o2){
	return o1 + (n-i1)*(o2-i1)/(i2-i1);
	
}

vec2 rotate(vec2 st, float a){
	st = mat2( cos(a) , -sin(a), sin(a), cos(a) ) * (st - 0.5);
	return st + 0.5;
}


float arc(float r, float r2, float fade, float spread, vec2 _st){
    
    float dist = sqrt(dot(_st,_st));
    float sm = smoothstep(r,r-0.018,dist);
    
    //modify this to make an animation
    float sm2 = smoothstep(r2,r2+fade,dist);
    float alpha = sm*sm2;
    float S = 0.854;
    float g = _st.x / dist;
    float ds = (1.0-pow(g,16.))*0.005;
    float sector = spread+g/2.;
    float s = smoothstep(S, S+ds, sector);  
    
    return alpha*s;
}


void main() {

	float t;

	if(animated == 0){		
		t = fract(TIME / 04.0);
	} else {
		t = ADSR;
	}
	
	
	
	vec2 st = isf_FragNormCoord;
	vec2 st01,st02,st03,st04;

	
	
	//50% performance increase if you DON'T USE a struct !!!!!	
	float 	time1[CNT],		time2[CNT],		time3[CNT],		time4[CNT];
	vec2 	st1[CNT],		st2[CNT],		st3[CNT],		st4[CNT];
	vec2 	LRot1[CNT],		LRot2[CNT],		LRot3[CNT],		LRot4[CNT];
	vec2 	LOffset1[CNT],	LOffset2[CNT],	LOffset3[CNT],	LOffset4[CNT];
	float 	ang1[CNT],		ang2[CNT],		ang3[CNT],		ang4[CNT];
	float 	orient1[CNT],	orient2[CNT],	orient3[CNT],	orient4[CNT];
	float 	dist1[CNT],		dist2[CNT],		dist3[CNT],		dist4[CNT];
	float	scale1[CNT],	scale2[CNT],	scale3[CNT],	scale4[CNT];
	float	stroke1[CNT],	stroke2[CNT],	stroke3[CNT],	stroke4[CNT];
	float	arc1[CNT],		arc2[CNT],		arc3[CNT],		arc4[CNT];
	
	vec3	color1,			color2,			color3,			color4			= vec3(0.0);
	

	
	st = rotate(isf_FragNormCoord,radians(globalOrient+90.));
		
	st01 = rotate(st,radians(layerAngle1));
	st02 = rotate(st,radians(layerAngle2));
	st03 = rotate(st,radians(layerAngle3));
	st04 = rotate(st,radians(layerAngle4));	
	
	st -= 0.5;
	st01 -= 0.5;
	st02 -= 0.5;	
	st03 -= 0.5;	
	st04 -= 0.5;


	//MAIN FOR LOOP
	for(int i=0;i < CNT; i++){
		
		vec4 item = vec4(0.5);
		
		if(mode == 1){
			item = IMG_PIXEL(fftImage, vec2(float(i)+0.5,float(0)+0.5));
			time1[i] = item.a;		//plane 0
			time2[i] = item.x;
			time3[i] = item.y;
			time4[i] = item.z;
		
		} else {
			time1[i] = t;
			time2[i] = t;
			time3[i] = t;
			time4[i] = t;
		}

	
		if(layer1enabled) {
	
			//LAYER 1
			//=========================================================		
			
			
			if(i < elements1) {	
		
				ang1[i] = radians((360./float(elements1))*float(i));
				orient1[i] = ang1[i] - PI/1.0;
				LRot1[i] = rotate(st01+0.5, orient1[i])-0.5;
				
				//ATTACK
				if(time1[i] > 0.0 && time1[i] < 0.25){
				
					float modT = linearstep(0.0,0.25,time1[i]);
							
					arc1[i] = arc(outside1,inside1,modT-1.,arclen1,LRot1[i]);			
					color1 += vec3(arc1[i]);
				}
			
				//DECAY
				if(time1[i] > 0.25 && time1[i] < 0.5){
			
					float modT = linearstep(0.25,0.50,time1[i]);
					
					//https://www.desmos.com/calculator/fve8lzjxcz
					float bumpT = -0.5*(-sqrt(modT)+modT)+1.;
					
					//other desmos example
					//bumpT = -2.*pow(modT,4.0) + 2.*modT+1.;
					
					arc1[i] = arc(outside1*bumpT,inside1,0.,arclen1,LRot1[i]);			
					color1 += vec3(arc1[i]);					

				}
			
				//SUSTAIN
				if(time1[i] > 0.5 && time1[i] < 0.75){
				
					float modT = linearstep(0.5,0.75,time1[i]);
					
					arc1[i] = arc(outside1,inside1,0.,arclen1,LRot1[i]);			
					color1 += vec3(arc1[i]);	
			
				}
			
				//RELEASE
				if(time1[i] > 0.75 && time1[i] < 1.0){
			
					float modT = linearstep(0.75,1.0,time1[i]);

					arc1[i] = arc(outside1,inside1,modT,arclen1,LRot1[i]);			
					color1 += vec3(arc1[i]);	
				
				}	
					
			} else {
				//break;
			}		

		}//layer1enabled
		
		
		if(layer2enabled){

			//LAYER 2
			//=========================================================

			if(i < elements2) {




			} else {
				//break;
			}

		}//layer2enabled

		if(layer3enabled){
		
			//LAYER 3
			//=========================================================
			
			if(i < elements3) {	
		


	
			} else {
				//break;
			}

		}//end if layer3enabled

		if(layer4enabled){

			//LAYER 4
			//=========================================================
			
			if(i < elements4) {	
		


	
			} else {
				//break;
			}

		}//layer4enabled

	} // END FOR

		//vec3 outColor = max(max(max(color1,color2),color3),color4);
		
		vec3 oc2 = vec3(c1);
		
		vec3 outColor = color1*MediumOrchid - color2*WHITE + color3*PaleGoldenrod - color4*WHITE;


		gl_FragColor = vec4(outColor, 1.0 );
	
}
