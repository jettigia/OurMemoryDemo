<template>
  <div id="editorBG" style="height:89%;">
    <!-- Create the editor container -->
    <div id="editor">
      <div id="editorPageBG">
        <form action="/action_page.php" id="memTxtFrm">
          <input
            type="text"
            name="memoryTitle"
            placeholder="Title"
            style="border:none; height:100%;"
          />
          <br />
          <br />
          <textarea
            style="width:100%;height:100%;border:none;"
            rows="26"
            wrap="hard"
            name="memoryContent"
            form="memTxtFrm"
            placeholder="Write memory here..."
          ></textarea>
          <br />
          <input
            type="submit"
            v-model="model.memory"
            class="btn btn-warning btn-lg"
            value="Save & Exit"
            style="width:90%"
          />
          <input
            type="submit"
            class="btn btn-secondary btn-lg"
            value="Exit"
            style="width:10%"
          />
        </form>
      </div>
    </div>
  </div>
</template>

<script>
import { mapState, mapActions } from "vuex";

export default {
  data() {
    return {
      model: {
        memory: "",
        memoryError: ""
      },
      show: true
    };
  },
  methods: {
    ...mapActions({
      register: "memory/createTextMemory"
    }),
    async onSubmit(evt) {
      evt.preventDefault();

      await this.createTextMemory({
        textContent: this.model.memory
      });

      if (this.memorySuccess) {
        // TODO close this window and refresh current window
      } else {
        this.memoryError = this.memoryStatus;
      }
    },
    onReset(evt) {
      evt.preventDefault();
      // Reset our form values
      this.model.memory = "";
      // Trick to reset/clear native browser form validation state
      this.show = false;
      this.$nextTick(() => {
        this.show = true;
      });
    }
  },
  computed: {
    ...mapState({
      memoryStatus: state => state.memoryUploadStatus,
      memorySuccess: state => state.memorySuccess
    })
  }
};
</script>

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
