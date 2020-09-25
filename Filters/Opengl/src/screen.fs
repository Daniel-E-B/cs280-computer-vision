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

// #version 460 core
// out vec4 FragColor;

// in vec2 TexCoords;

// uniform sampler2D screenTexture;

// void main()
// {
//     float texHeight = 799;
//     float texWidth = 1200;
//     vec4 texcolor = vec4(0.0, 0.0, 0.0, 1.0);

//     texcolor += texture(screenTexture, vec2(TexCoords.x - 1/texWidth, TexCoords.y - 1/texHeight));

//     texcolor -= texture(screenTexture, vec2(TexCoords.x + 1/texWidth, TexCoords.y - 1/texHeight));


//     texcolor += texture(screenTexture, vec2(TexCoords.x - 1/texWidth, TexCoords.y));

//     texcolor -= 2*texture(screenTexture, vec2(TexCoords.x + 1/texWidth, TexCoords.y));


//     texcolor += texture(screenTexture, vec2(TexCoords.x - 1/texWidth, TexCoords.y + 1/texHeight));

//     texcolor -= texture(screenTexture, vec2(TexCoords.x + 1/texWidth, TexCoords.y + 1/texHeight));
    
//     FragColor = texcolor;
// }

// // [1,0-1],
// // [2,0,-2]
// // [1,0,-1]