/*{
    "CATEGORIES": [
        "PUBLISH"
    ],
    "DESCRIPTION": "20200811_funkineue",
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
            "DEFAULT": 0.15,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param01",
            "LABEL": "outside edge 1",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.1,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param02",
            "LABEL": "inside edge 1",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.5,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param03",
            "LABEL": "arc length 1",
            "TYPE": "float"
        },     
        {
            "DEFAULT": 0.0,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param04",
            "LABEL": "unused",
            "TYPE": "float"
        },    
        {
            "DEFAULT": 0.25,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param05",
            "LABEL": "outside edge 2",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.2,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param06",
            "LABEL": "inside edge 2",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.5,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param07",
            "LABEL": "arc length 2",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.5,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param08",
            "LABEL": "unused",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.35,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param09",
            "LABEL": "outside edge 3",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.3,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param10",
            "LABEL": "inside edge 3",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.5,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param11",
            "LABEL": "arc length 3",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.5,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param12",
            "LABEL": "unused",
            "TYPE": "float"
        },        
        {
            "DEFAULT": 0.45,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param13",
            "LABEL": "outside edge 4",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.4,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param14",
            "LABEL": "inside edge 4",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.5,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param15",
            "LABEL": "arc length 4",
            "TYPE": "float"
        },    
        {
            "DEFAULT": 0.5,
            "MAX": 1.0,
            "MIN": 0.0,
            "NAME": "param16",
            "LABEL": "unused",
            "TYPE": "float"
        },     
        {
            "DEFAULT": 0,
            "MAX": 360,
            "MIN": 0,
            "NAME": "layerAngle1",
            "LABEL": "local rotate 1",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0,
            "MAX": 360,
            "MIN": 0,
            "NAME": "layerAngle2",
            "LABEL": "local rotate 2",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0,
            "MAX": 360,
            "MIN": 0,
            "NAME": "layerAngle3",
            "LABEL": "local rotate 3",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0,
            "MAX": 360,
            "MIN": 0,
            "NAME": "layerAngle4",
            "LABEL": "local rotate 4",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0,
            "MAX": 360,
            "MIN": 0,
            "NAME": "globalOrient",
            "LABEL": "global rotate",
            "TYPE": "float"
        },
        {
            "DEFAULT": true,
            "LABEL": "layer1",
            "NAME": "layer1enabled",
            "TYPE": "bool"
        },
        {
            "DEFAULT": true,
            "LABEL": "layer2",
            "NAME": "layer2enabled",
            "TYPE": "bool"
        },
        {
            "DEFAULT": true,
            "LABEL": "layer3",
            "NAME": "layer3enabled",
            "TYPE": "bool"
        },
        {
            "DEFAULT": true,
            "LABEL": "layer4",
            "NAME": "layer4enabled",
            "TYPE": "bool"
        },
        {
            "LABEL": "c1",
            "NAME": "c1",
            "TYPE": "color",
            "DEFAULT" : [
				0.250,
				0.215,
				0.964,
				1
			  ]
        },
        {
            "LABEL": "c2",
            "NAME": "c2",
            "TYPE": "color",
            "DEFAULT" : [
				0.964,
				0.360,
				0.215,
				1
			  ]
        },
        {
            "LABEL": "c3",
            "NAME": "c3",
            "TYPE": "color",
            "DEFAULT" : [
				0.902,
				0.902,
				0.980,
				1
			  ]
        },
        {
            "LABEL": "c4",
            "NAME": "c4",
            "TYPE": "color",
            "DEFAULT" : [
				0.933,
				0.910,
				0.667,
				1
			  ]
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
	vec2 gSt_01,gSt_02,gSt_03,gSt_04;

	//50% performance increase if you DON'T USE a struct !!!!!	
	float 	time_1[CNT],	time_2[CNT],	time_3[CNT],	time_4[CNT];
	vec2 	st_1[CNT],		st_2[CNT],		st_3[CNT],		st_4[CNT];
	vec2 	LRot_1[CNT],	LRot_2[CNT],	LRot_3[CNT],	LRot_4[CNT];
	vec2 	LOffset_1[CNT],	LOffset_2[CNT],	LOffset_3[CNT],	LOffset_4[CNT];
	float 	ang_1[CNT],		ang_2[CNT],		ang_3[CNT],		ang_4[CNT];
	float 	orient_1[CNT],	orient_2[CNT],	orient_3[CNT],	orient_4[CNT];
	float 	dist_1[CNT],	dist_2[CNT],	dist_3[CNT],	dist_4[CNT];
	float	scale_1[CNT],	scale_2[CNT],	scale_3[CNT],	scale_4[CNT];
	float	stroke_1[CNT],	stroke_2[CNT],	stroke_3[CNT],	stroke_4[CNT];
	float	arc_1[CNT],		arc_2[CNT],		arc_3[CNT],		arc_4[CNT];	
	vec3	color_1,		color_2,		color_3,		color_4			= vec3(0.0);
	
	st = rotate(isf_FragNormCoord,radians(globalOrient+90.));
		
	gSt_01 = rotate(st,radians(layerAngle1));
	gSt_02 = rotate(st,radians(layerAngle2));
	gSt_03 = rotate(st,radians(layerAngle3));
	gSt_04 = rotate(st,radians(layerAngle4));	
	
	st -= 0.5;
	gSt_01 -= 0.5;
	gSt_02 -= 0.5;	
	gSt_03 -= 0.5;	
	gSt_04 -= 0.5;


	//param remapping
	//float outside1 = map(param01,0.0,1.0,0.0,1.0);
	//float inside1 = map(param02,0.0,1.0,0.0,1.0);
	float arclen1 = map(param03,0.0,1.0,0.35,0.5);
	//float pMap1d = map(param04,0.0,1.0,0.0,1.0);
	
	//float pMap2a = map(param05,0.0,1.0,0.0,1.0);
	//float pMap2b = map(param06,0.0,1.0,0.0,1.0);
	float arclen2 = map(param07,0.0,1.0,0.35,0.5);
	//float pMap2d = map(param08,0.0,1.0,0.0,1.0);
	
	//float pMap3a = map(param09,0.0,1.0,0.0,1.0);
	//float pMap3b = map(param10,0.0,1.0,0.0,1.0);
	float arclen3 = map(param11,0.0,1.0,0.35,0.5);
	//float pMap3d = map(param12,0.0,1.0,0.0,1.0);
	
	//float pMap4a = map(param13,0.0,1.0,0.0,1.0);
	//float pMap4b = map(param14,0.0,1.0,0.0,1.0);
	float arclen4 = map(param15,0.0,1.0,0.35,0.5);
	//float pMap4d = map(param16,0.0,1.0,0.0,1.0);
	

	//MAIN FOR LOOP
	for(int i=0;i < CNT; i++){
		
		vec4 item = vec4(0.5);
		
		if(mode == 1){
			item = IMG_PIXEL(fftImage, vec2(float(i)+0.5,float(0)+0.5));
			time_1[i] = item.a;		//plane 0
			time_2[i] = item.x;
			time_3[i] = item.y;
			time_4[i] = item.z;
		
		} else {
			time_1[i] = t;
			time_2[i] = t;
			time_3[i] = t;
			time_4[i] = t;
		}

	
		if(layer1enabled) {
	
			//LAYER 1
			//=========================================================		
					
			if(i < elements1) {	
			
				ang_1[i] = radians((360./float(elements1))*float(i));
				orient_1[i] = ang_1[i] - PI/1.0;
				LRot_1[i] = rotate(gSt_01+0.5, orient_1[i])-0.5;
				
				//ATTACK
				if(time_1[i] > 0.0 && time_1[i] < 0.25){
				
					float modT = linearstep(0.0,0.25,time_1[i]);
							
					arc_1[i] = arc(param01,param02,modT-1.,arclen1,LRot_1[i]);			
					color_1 += vec3(arc_1[i]);
				}
			
				//DECAY
				if(time_1[i] > 0.25 && time_1[i] < 0.5){
			
					float modT = linearstep(0.25,0.50,time_1[i]);
					
					//https://www.desmos.com/calculator/fve8lzjxcz
					float bumpT = -0.5*(-sqrt(modT)+modT)+1.;
					
					//other desmos example
					//bumpT = -2.*pow(modT,4.0) + 2.*modT+1.;
					
					arc_1[i] = arc(param01*bumpT,param02,0.,arclen1,LRot_1[i]);			
					color_1 += vec3(arc_1[i]);					

				}
			
				//SUSTAIN
				if(time_1[i] > 0.5 && time_1[i] < 0.75){
				
					float modT = linearstep(0.5,0.75,time_1[i]);
					
					arc_1[i] = arc(param01,param02,0.,arclen1,LRot_1[i]);			
					color_1 += vec3(arc_1[i]);	
			
				}
			
				//RELEASE
				if(time_1[i] > 0.75 && time_1[i] < 1.0){
			
					float modT = linearstep(0.75,1.0,time_1[i]);

					arc_1[i] = arc(param01,param02,modT,arclen1,LRot_1[i]);			
					color_1 += vec3(arc_1[i]);	
				
				}	
				
					
			} else {
				//break;
			}		

		}//layer1enabled
		
		
		if(layer2enabled){

			//LAYER 2
			//=========================================================

			if(i < elements2) {


				ang_2[i] = radians((360./float(elements2))*float(i));
				orient_2[i] = ang_2[i] - PI/1.0;
				LRot_2[i] = rotate(gSt_02+0.5, orient_2[i])-0.5;
				
				//ATTACK
				if(time_2[i] > 0.0 && time_2[i] < 0.25){
				
					float modT = linearstep(0.0,0.25,time_2[i]);
							
					arc_2[i] = arc(param05,param06,modT-1.,arclen2,LRot_2[i]);			
					color_2 += vec3(arc_2[i]);
				}
			
				//DECAY
				if(time_2[i] > 0.25 && time_2[i] < 0.5){
			
					float modT = linearstep(0.25,0.50,time_2[i]);
					
					//https://www.desmos.com/calculator/fve8lzjxcz
					float bumpT = -0.5*(-sqrt(modT)+modT)+1.;
					
					//other desmos example
					//bumpT = -2.*pow(modT,4.0) + 2.*modT+1.;
					
					arc_2[i] = arc(param05*bumpT,param06,0.,arclen2,LRot_2[i]);			
					color_2 += vec3(arc_2[i]);					

				}
			
				//SUSTAIN
				if(time_2[i] > 0.5 && time_2[i] < 0.75){
				
					float modT = linearstep(0.5,0.75,time_2[i]);
					
					arc_2[i] = arc(param05,param06,0.,arclen2,LRot_2[i]);			
					color_2 += vec3(arc_2[i]);	
			
				}
			
				//RELEASE
				if(time_2[i] > 0.75 && time_2[i] < 1.0){
			
					float modT = linearstep(0.75,1.0,time_2[i]);

					arc_2[i] = arc(param05,param06,modT,arclen2,LRot_2[i]);			
					color_2 += vec3(arc_2[i]);	
				
				}	


			} else {
				//break;
			}

		}//layer2enabled

		if(layer3enabled){
		
			//LAYER 3
			//=========================================================
			
			if(i < elements3) {	
		
				ang_3[i] = radians((360./float(elements3))*float(i));
				orient_3[i] = ang_3[i] - PI/1.0;
				LRot_3[i] = rotate(gSt_03+0.5, orient_3[i])-0.5;
				
				//ATTACK
				if(time_3[i] > 0.0 && time_3[i] < 0.25){
				
					float modT = linearstep(0.0,0.25,time_3[i]);
							
					arc_3[i] = arc(param09,param10,modT-1.,arclen3,LRot_3[i]);			
					color_3 += vec3(arc_3[i]);
				}
			
				//DECAY
				if(time_3[i] > 0.25 && time_3[i] < 0.5){
			
					float modT = linearstep(0.25,0.50,time_3[i]);
					
					//https://www.desmos.com/calculator/fve8lzjxcz
					float bumpT = -0.5*(-sqrt(modT)+modT)+1.;
					
					//other desmos example
					//bumpT = -2.*pow(modT,4.0) + 2.*modT+1.;
					
					arc_3[i] = arc(param09*bumpT,param10,0.,arclen3,LRot_3[i]);			
					color_3 += vec3(arc_3[i]);					

				}
			
				//SUSTAIN
				if(time_3[i] > 0.5 && time_3[i] < 0.75){
				
					float modT = linearstep(0.5,0.75,time_3[i]);
					
					arc_3[i] = arc(param09,param10,0.,arclen3,LRot_3[i]);			
					color_3 += vec3(arc_3[i]);	
			
				}
			
				//RELEASE
				if(time_3[i] > 0.75 && time_3[i] < 1.0){
			
					float modT = linearstep(0.75,1.0,time_3[i]);

					arc_3[i] = arc(param09,param10,modT,arclen3,LRot_3[i]);			
					color_3 += vec3(arc_3[i]);	
				
				}	

	
			} else {
				//break;
			}

		}//end if layer3enabled

		if(layer4enabled){

			//LAYER 4
			//=========================================================
			
			if(i < elements4) {	
		
				ang_4[i] = radians((360./float(elements4))*float(i));
				orient_4[i] = ang_4[i] - PI/1.0;
				LRot_4[i] = rotate(gSt_04+0.5, orient_4[i])-0.5;
				
				//ATTACK
				if(time_4[i] > 0.0 && time_4[i] < 0.25){
				
					float modT = linearstep(0.0,0.25,time_4[i]);
							
					arc_4[i] = arc(param13,param14,modT-1.,arclen4,LRot_4[i]);			
					color_4 += vec3(arc_4[i]);
				}
			
				//DECAY
				if(time_4[i] > 0.25 && time_4[i] < 0.5){
			
					float modT = linearstep(0.25,0.50,time_4[i]);
					
					//https://www.desmos.com/calculator/fve8lzjxcz
					float bumpT = -0.5*(-sqrt(modT)+modT)+1.;
					
					//other desmos example
					//bumpT = -2.*pow(modT,4.0) + 2.*modT+1.;
					
					arc_4[i] = arc(param13*bumpT,param14,0.,arclen4,LRot_4[i]);			
					color_4 += vec3(arc_4[i]);					

				}
			
				//SUSTAIN
				if(time_4[i] > 0.5 && time_4[i] < 0.75){
				
					float modT = linearstep(0.5,0.75,time_4[i]);
					
					arc_4[i] = arc(param13,param14,0.,arclen4,LRot_4[i]);			
					color_4 += vec3(arc_4[i]);	
			
				}
			
				//RELEASE
				if(time_4[i] > 0.75 && time_4[i] < 1.0){
			
					float modT = linearstep(0.75,1.0,time_4[i]);

					arc_4[i] = arc(param13,param14,modT,arclen4,LRot_4[i]);			
					color_4 += vec3(arc_4[i]);	
				
				}	

	
			} else {
				//break;
			}

		}//layer4enabled

	} // END FOR

		//vec3 outColor = max(max(max(color_1,color_2),color_3),color_4);
				
		//color picker 1
		vec3 pickedColor1 = vec3(c1);
		vec3 pickedColor2 = vec3(c2);
		vec3 pickedColor3 = vec3(c3);
		vec3 pickedColor4 = vec3(c4);
		
		vec3 outColor = color_1*pickedColor1 + color_2*pickedColor2 + color_3*pickedColor3 + color_4*pickedColor4;

		gl_FragColor = vec4(outColor, 0.75);
	
}
