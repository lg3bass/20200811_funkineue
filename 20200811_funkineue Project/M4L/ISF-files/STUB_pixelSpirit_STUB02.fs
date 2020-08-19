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
            "DEFAULT": 0.05,
            "MAX": 0.35,
            "MIN": 0.01,
            "NAME": "cStroke",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.25,
            "MAX": 1,
            "MIN": 0,
            "NAME": "cScale",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0.15,
            "MAX": 1,
            "MIN": 0,
            "NAME": "cDist",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0,
            "MAX": 0.5,
            "MIN": 0,
            "NAME": "orbit",
            "TYPE": "float"
        },
        {
            "DEFAULT": 45,
            "MAX": 360,
            "MIN": 0,
            "NAME": "orient1",
            "TYPE": "float"
        },
        {
            "DEFAULT": 90,
            "MAX": 360,
            "MIN": 0,
            "NAME": "orient2",
            "TYPE": "float"
        },
        {
            "DEFAULT": 0,
            "MAX": 360,
            "MIN": 0,
            "NAME": "orient3",
            "TYPE": "float"
        },
        {
            "DEFAULT": 90,
            "MAX": 360,
            "MIN": 0,
            "NAME": "orient4",
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

void main() {


	float t = fract(TIME / 04.0);
	vec2 st = isf_FragNormCoord;
	
	
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
	vec3	color1,			color2,			color3,			color4			= vec3(0.0);
	

	
	st = rotate(isf_FragNormCoord,radians(globalOrient));
	st -= 0.5;

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
		
				scale1[i] = cScale;
				stroke1[i] = cStroke;

				ang1[i] = radians((360./float(elements1))*float(i));
				orient1[i] = ang1[i] - PI/2.0;
				dist1[i] = cDist;
				LOffset1[i] = vec2(dist1[i]*cos(ang1[i]),dist1[i]*sin(ang1[i]));
				
				//ATTACK
				if(time1[i] > 0.0 && time1[i] < 0.25){
				
					float modT = linearstep(0.0,0.25,time1[i]);
					LOffset1[i] *= modT;
			
					color1  += stroke(circleSDF(LOffset1[i],st), scale1[i]*modT, stroke1[i]*modT);
				}
			
				//DECAY
				if(time1[i] > 0.25 && time1[i] < 0.5){
				
					float modStroke = stroke1[i]*2.;
				
					float modT = linearstep(0.25,0.50,time1[i]);
					float modScale = map(modT, 0.0, 1., stroke1[i], modStroke+0.1);
				
					color1  += stroke(circleSDF(LOffset1[i],st), scale1[i], modStroke*2.+.1-modScale);
				}
			
				//SUSTAIN
				if(time1[i] > 0.5 && time1[i] < 0.75){
				
					float modT = linearstep(0.5,0.75,time1[i]);
			
					color1  += stroke(circleSDF(LOffset1[i],st), scale1[i], stroke1[i]);			
				}
			
				//RELEASE
				if(time1[i] > 0.75 && time1[i] < 1.0){
			
					float modT = linearstep(0.75,1.0,time1[i]);
					float modTinverse = 1.0-modT;	
								
					color1  += stroke(circleSDF(LOffset1[i],st), scale1[i]*modTinverse, stroke1[i]*modTinverse);
				
				}		
			} else {
				//break;
			}		

		}//layer1enabled
		
		
		if(layer2enabled){

			//LAYER 2
			//=========================================================

			if(i < elements2) {

				scale2[i] = cScale+0.3;
				stroke2[i] = cStroke;

				ang2[i] = radians((360./float(elements2))*float(i));
				orient2[i] = ang2[i] - PI/2.0;
				dist2[i] = cDist+0.05;
				LOffset2[i] = vec2(dist2[i]*cos(ang2[i]),dist2[i]*sin(ang2[i]));
						
				//ATTACK
				if(time2[i] > 0.0 && time2[i] < 0.25){
				
					float modT = linearstep(0.0,0.25,time2[i]);
					LOffset2[i] *= modT;
							
					LRot2[i] = rotate(0.5-st+LOffset2[i], orient2[i]);
					color2  += stroke(rectSDF(LRot2[i],vec2(0.4)),scale2[i]*modT, stroke2[i]*modT);
				}
			
				//DECAY
				if(time2[i] > 0.25 && time2[i] < 0.5){
				
					float modStroke = stroke2[i]*2.;
				
					float modT = linearstep(0.25,0.50,time2[i]);
					float modScale = map(modT, 0.0, 1., stroke2[i], modStroke+0.1);
					
					LRot2[i] = rotate(0.5-st+LOffset2[i], orient2[i]);
					color2  += stroke(rectSDF(LRot2[i],vec2(0.4)), scale2[i], modStroke*2.+.1-modScale);
				}
			
				//SUSTAIN
				if(time2[i] > 0.5 && time2[i] < 0.75){
				
					float modT = linearstep(0.5,0.75,time2[i]);
			
					LRot2[i] = rotate(0.5-st+LOffset2[i], orient2[i]);
					color2  += stroke(rectSDF(LRot2[i],vec2(0.4)),scale2[i],stroke2[i]);			
				}
			
				//RELEASE
				if(time2[i] > 0.75 && time2[i] < 1.0){
			
					float modT = linearstep(0.75,1.0,time2[i]);
					float modTinverse = 1.0-modT;	
								
					LRot2[i] = rotate(0.5-st+LOffset2[i], orient2[i]);
					color2  += stroke(rectSDF(LRot2[i],vec2(0.4)),scale2[i]*modTinverse,stroke2[i]*modTinverse);				
				}		
			} else {
				//break;
			}

		}//layer2enabled

		if(layer3enabled){
		
			//LAYER 3
			//=========================================================
			
			if(i < elements3) {	
		
				scale3[i] = 0.2;
				stroke3[i] = 0.04;

				ang3[i] = radians((360./float(elements3))*float(i));
				orient3[i] = ang3[i] - PI/2.0;
				dist3[i] = cDist+0.1;
				LOffset3[i] = vec2(dist3[i]*cos(ang3[i]),dist3[i]*sin(ang3[i]));
						
				//ATTACK
				if(time3[i] > 0.0 && time3[i] < 0.25){
				
					float modT = linearstep(0.0,0.25,time3[i]);
					LOffset3[i] *= modT;
			
					LRot3[i] = rotate(0.5-st+LOffset3[i], orient3[i]);
					color3  += stroke(triSDF(LRot3[i]),scale3[i]*modT, stroke3[i]*modT);
				}
			
				//DECAY
				if(time3[i] > 0.25 && time3[i] < 0.5){
				
					float modStroke = stroke3[i]*2.;
				
					float modT = linearstep(0.25,0.50,time3[i]);
					float modScale = map(modT, 0.0, 1., stroke3[i], modStroke+0.1);
				
					LRot3[i] = rotate(0.5-st+LOffset3[i], orient3[i]);
					color3  += stroke(triSDF(LRot3[i]), scale3[i], modStroke*2.+.1-modScale);
				}
			
				//SUSTAIN
				if(time3[i] > 0.5 && time3[i] < 0.75){
				
					float modT = linearstep(0.5,0.75,time3[i]);
					
					LRot3[i] = rotate(0.5-st+LOffset3[i], orient3[i]);
					color3  += stroke(triSDF(LRot3[i]), scale3[i], stroke3[i]);			
				}
			
				//RELEASE
				if(time3[i] > 0.75 && time3[i] < 1.0){
			
					float modT = linearstep(0.75,1.0,time3[i]);
					float modTinverse = 1.0-modT;	
					
					LRot3[i] = rotate(0.5-st+LOffset3[i], orient3[i]);
					color3  += stroke(triSDF(LRot3[i]), scale3[i]*modTinverse, stroke3[i]*modTinverse);
				
				}		
			} else {
				//break;
			}

		}//end if layer3enabled

		if(layer4enabled){

			//LAYER 4
			//=========================================================
			
			if(i < elements4) {	
		
				scale4[i] = cScale;
				stroke4[i] = cStroke;

				ang4[i] = radians((360./float(elements4))*float(i));
				orient4[i] = ang4[i] - PI/2.0;
				dist4[i] = cDist+0.2;
				LOffset4[i] = vec2(dist4[i]*cos(ang4[i]),dist4[i]*sin(ang4[i]));
					
				//ATTACK
				if(time4[i] > 0.0 && time4[i] < 0.25){
				
					float modT = linearstep(0.0,0.25,time4[i]);
					LOffset4[i] *= modT;
			
					LRot4[i] = rotate(0.5-st+LOffset4[i], orient4[i]);
					color4  += stroke(hexSDF(LRot4[i]),scale4[i]*modT, stroke4[i]*modT);
				}
			
				//DECAY
				if(time4[i] > 0.25 && time4[i] < 0.5){
				
					float modStroke = stroke4[i]*2.;
				
					float modT = linearstep(0.25,0.50,time4[i]);
					float modScale = map(modT, 0.0, 1., stroke4[i], modStroke+0.1);
				
					LRot4[i] = rotate(0.5-st+LOffset4[i], orient4[i]);
					color4  += stroke(hexSDF(LRot4[i]), scale4[i], modStroke*2.+.1-modScale);
				}
			
				//SUSTAIN
				if(time4[i] > 0.5 && time4[i] < 0.75){
				
					float modT = linearstep(0.5,0.75,time4[i]);
					
					LRot4[i] = rotate(0.5-st+LOffset4[i], orient4[i]);
					color4  += stroke(hexSDF(LRot4[i]), scale4[i], stroke4[i]);			
				}
			
				//RELEASE
				if(time4[i] > 0.75 && time4[i] < 1.0){
			
					float modT = linearstep(0.75,1.0,time4[i]);
					float modTinverse = 1.0-modT;	
					
					LRot4[i] = rotate(0.5-st+LOffset4[i], orient4[i]);
					color4  += stroke(hexSDF(LRot4[i]), scale4[i]*modTinverse, stroke4[i]*modTinverse);
				
				}		
			} else {
				//break;
			}

		}//layer4enabled

	} // END FOR

		//vec3 outColor = max(max(max(color1,color2),color3),color4);
		vec3 outColor = color1*SWEETPEA + color2*BLUE + color3*REDORANGE + color4*YELLOW;


		gl_FragColor = vec4(outColor, 1.0 );
	
}
