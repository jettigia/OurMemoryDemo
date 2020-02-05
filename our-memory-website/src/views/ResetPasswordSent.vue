<!-- RALPH - Step 2: User has entered their email address, an email verification is sent, and is redirected to this page  -->
<template>
  <div id="editorBG" style="height:89%;">
    <!-- Create the editor container -->
    <div id="editor">
      <div id="editorPageBG">
        <div
          style="width:100%;height:60%;text-align:center;position: absolute;bottom: 0;left: 0;"
        >
          <h2>Password Reset Email Has Been Sent!</h2>
          <p>
            Look out in your inbox for your password reset link.
          </p>
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
  height: 80%;
}
#editorBG {
  background-color: #f4f4f4;
}
#editorPageBG {
  background-color: #ffffff;
  margin: auto;
  width: 70%;
  height: 100%;
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