<!-- RALPH - Step 1: User has clicked [Forgot password] on login dropdown and is redirected to this page  -->
<template>
  <div id="editorBG" style="height:89%;">
    <!-- Create the editor container -->
    <div id="editor">
      <div id="editorPageBG" style="padding:60px;">
          <h1> Password Reset </h1>
          <br>
        <form action="#" id="PasswordResetFrm">
          <input
            type="text"
            name="UserEmail"
            placeholder="Email"
            
          />
          <br />
          <br />
          
          <br />
          <input
            type="submit"
            class="btn btn-warning btn-lg"
            value="Send password reset email"
          />
        </form>
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