#version 460 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D screenTexture;

void main()
{
    float texheight = 799;
    vec4 texcolor = vec4(0.0, 0.0, 0.0, 1.0);
    for(int y = -50; y <= 50; ++y){
        vec2 samplepos = vec2(TexCoords.x, TexCoords.y + y/texheight);
        texcolor += texture(screenTexture, samplepos) * 1.0/101.0;
    }
    FragColor = texcolor;
}