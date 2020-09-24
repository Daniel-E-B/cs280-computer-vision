#version 460 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

uniform sampler2D ourTexture;

void main()
{
    float texwidth = 1200;
    float texheight = 799;
    vec4 texcolor = vec4(0.0, 0.0, 0.0, 1.0);
    for(int y = -50; y <= 50; ++y){
        for(int x = -50; x<= 50; ++x){
            vec2 samplepos = vec2(TexCoord.x + x/texwidth, TexCoord.y + y/texheight);
            texcolor += texture(ourTexture, samplepos) * 1.0/(101.0 * 101);
        }
    }
    FragColor = texcolor;
}