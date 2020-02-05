<!-- RALPH - Step 4: User has entered new password correctly and is redirected to this page -->
<template>
  <div id="editorBG" style="height:89%;">
    <!-- Create the editor container -->
    <div id="editor">
      <div id="editorPageBG">
        <div
          style="width:100%;height:60%;text-align:center;position: absolute;bottom: 0;left: 0;"
        >
          <h2>Password Reset Successful!</h2>
          <p>
            Go back to
            <router-link
              style="color:black;text-decoration: underline;"
              to="/Home"
              >Home</router-link
            > and try logging in
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