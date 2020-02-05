<template>
  <div style="height:88.6%;z-index:-1;">
    <!-- Memory Display section  -->

    <div
      id="modalImage1"
      class="modal fade"
      tabindex="-1"
      role="dialog"
      aria-labelledby="myModalLabel"
      aria-hidden="true"
    >
      <div class="modal-dialog-centered">
        <div class="modal-content">
          <div class="modal-header">
            <button
              type="button"
              class="close font-weight-light"
              data-dismiss="modal"
              aria-hidden="true"
            >
              ×
            </button>
          </div>
          <div class="modal-body">
            <div style="margin: 0 auto; width:50%;">
              <img
                src="https://picsum.photos/1280/800?random"
                alt=""
                title="Image Memory"
              />
              <p>Image description here..</p>
            </div>
          </div>
        </div>
      </div>
    </div>

    <div class="grid-container">
      <div class="search" style="height: 100%;">
        <!-- Search -->
        <form class="form" role="form" style="height: 100%;padding-left:5%;">
          <div class="form-group" style="height: 100%;">
            <input
              id="searchInput"
              placeholder="🔍Search Memories"
              class="form-control form-control-sm"
              style=" border:none; height: 100%;"
              type="text"
              required=""
            />
          </div>
        </form>
      </div>

      <div class="Actions">
        <!-- Actions -->

        <div width="100%">
          <div>
            <!-- move to right  -->
            <label class="dropdown">
              <div class="dd-button">
                + New
              </div>
              <input type="checkbox" class="dd-input" id="test" />
              <ul class="dd-menu">
                <li>
                  <router-link to="/NewTextMemory">Text Memory</router-link>
                </li>
                <li>
                  <router-link to="/NewPhotoMemory">Photo Memory</router-link>
                </li>
                <li>
                  <router-link to="/NewVideoMemory">Video Memory</router-link>
                </li>
              </ul>
            </label>

            <label class="dropdown">
              <div class="dd-button">
                Sort
              </div>
              <input type="checkbox" class="dd-input" id="test" />
              <ul class="dd-menu">
                <li>✔ Date Created</li>
                <li>Name</li>
                <li class="divider"></li>
                <li>✔ Ascending</li>
                <li>Decending</li>
              </ul>
            </label>
          </div>
        </div>
      </div>

      <div class="Folders">
        <!-- Folders -->
        <div
          style="height:100%; width:100%;"
          id="list-example"
          class="list-group"
        >
          <p style="padding-top:15%;padding-left:10%;font-size:12px;">Albums</p>

          <a class="list-group-item list-group-item-action" href="#list-item-1"
            >November 2019</a
          >
          <a class="list-group-item list-group-item-action" href="#list-item-2"
            >Janurary 2020</a
          >
          <a class="list-group-item list-group-item-action" href="#list-item-3"
            >February 2020</a
          >
          <a class="list-group-item list-group-item-action" href="#list-item-4"
            >March 2020</a
          >
        </div>
      </div>

      <div class="Gallery">
        <!-- Gallery -->

        <div style="height:80%; width:100%;">
          <div
            data-spy="scroll"
            data-target="#list-example"
            data-offset="0"
            class="scrollspy-example GalleryContainer"
          >
            <p id="list-item-1">November 2019</p>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <div class="clear"></div>
            <br />
            <p id="list-item-2">Janurary 2020</p>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <div class="clear"></div>
            <br />
            <p id="list-item-3">February 2020</p>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <div class="clear"></div>
            <br />
            <p id="list-item-4">March 2020</p>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img
                src="https://picsum.photos/150/150?random"
                alt=""
                title="Beautiful Image"
            /></a>
            <a href="#" data-toggle="modal" data-target="#modalImage1"
              ><img src="https://picsum.photos/150/150?random" alt="" title=""
            /></a>
            <div class="clear"></div>
          </div>
        </div>
      </div>
    </div>
    <!-- Portfolio section end  -->
  </div>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
  data() {
    return {
      error: false,
      errorMessage: ""
    };
  },
  mounted() {
    this.getMemories();
  },
  methods: {
    ...mapActions({
      getMemories: "memory/getMemories"
    })
  },
  computed: {
    ...mapState({
      memories: state => state.memories
    })
  }
};
</script>

<style scoped>
.grid-container {
  width: 100%;
  height: 100%;
  display: grid;
  grid-template-columns: 15% 100%;
  grid-template-rows: 5% 100%;
  grid-template-areas: "search Actions" "Folders Gallery";
  position: fixed;
  top: 72px;
}

.search {
  grid-area: search;
  border-right-style: solid;
  border-bottom-style: solid;
  border-width: 2px;
  border-color: #eaeaea;
}

.Actions {
  grid-area: Actions;
  background-color: #f4f4f4;
}
.ActionContent {
}

.Folders {
  grid-area: Folders;
  border-right-style: solid;
  border-width: 2px;
  border-color: #eaeaea;
}

.Gallery {
  grid-area: Gallery;
  height: 100%;
}
.GalleryContainer {
  padding-right: 15px;
  padding-left: 15px;
  margin-right: 15%;
  margin-left: auto;
  overflow: auto;
  height: 100%;
}

/* ----------------------------------------------------------------- */

a {
  text-decoration: none;
  color: #000000;
}

a:hover {
  color: #222222;
}

/* Dropdown */

.dropdown {
  display: inline-block;
  position: relative;
}

.dd-button {
  display: inline-block;
  /* border: 1px solid gray; */
  /* border-radius: 4px; */
  padding: 10px 30px 10px 20px;
  background-color: #f4f4f4;
  cursor: pointer;
  white-space: nowrap;
}

.dd-button:after {
  content: "";
  position: absolute;
  top: 50%;
  right: 15px;
  transform: translateY(-50%);
  width: 0;
  height: 0;
  border-left: 5px solid transparent;
  border-right: 5px solid transparent;
  border-top: 5px solid black;
}

.dd-button:hover {
  background-color: #eeeeee;
}

.dd-input {
  display: none;
}

.dd-menu {
  position: absolute;
  top: 100%;
  border: 1px solid #ccc;
  border-radius: 4px;
  padding: 0;
  margin: 2px 0 0 0;
  box-shadow: 0 0 6px 0 rgba(0, 0, 0, 0.1);
  background-color: #ffffff;
  list-style-type: none;
}

.dd-input + .dd-menu {
  display: none;
}

.dd-input:checked + .dd-menu {
  display: block;
}

.dd-menu li {
  padding: 10px 20px;
  cursor: pointer;
  white-space: nowrap;
}

.dd-menu li:hover {
  background-color: #f6f6f6;
}

.dd-menu li a {
  display: block;
  margin: -10px -20px;
  padding: 10px 20px;
}

.dd-menu li.divider {
  padding: 0;
  border-bottom: 1px solid #cccccc;
}
</style>
