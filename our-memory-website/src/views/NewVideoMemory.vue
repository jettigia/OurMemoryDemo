<template>
   <div id="editorBG" style="height:89%;">

        <!-- RALPH -->
        <!-- I used: https://www.dropzonejs.com/ for the drag and drop file upload -->

        <!-- Create the editor container -->
        <div id="editor">
            <div id="editorPageBG">
                <div id="dropzone" style="width:100%;height:60%;text-align:center;position: absolute;bottom: 0;left: 0;">
                    <div style="border-style:dashed;width:40%;height:50%;position:absolute;bottom:50%;left:30%;">
                    <form action="/file-upload" class="dropzone needsclick" id="demo-upload">
                        <div class="dz-message needsclick" >
                            <h3>Drop video files here or click to upload.</h3>
                            <br />
                            <span class="note needsclick">(Allowed video files: <strong>MP4, WMV, AVI, MOV, WEBM</strong>)</span>
                        </div>
                        <div class="fallback">
                            <input name="file" type="file" multiple />
                        </div>
                    </form>
                    </div>
                </div>
            </div>
        </div>


    </div>
</template>

<style scoped>
    #editor {
        position: fixed;
        top: 80px;
        width: 100%;
        height:80%;
    }
    #editorBG {
        background-color: #f4f4f4;
    }
    #editorPageBG {
        
        background-color: #ffffff;
        margin: auto;
        width: 70%;
        height:100%;
        border: 3px solid #e7e7e7;
        padding: 2px;
    }
    #editor-container {
        height: 375px;
    }
    #textarea {
        width: 100vw;
    height: 100vh;
    }

</style>