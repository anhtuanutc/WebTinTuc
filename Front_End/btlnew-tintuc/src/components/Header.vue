<template>
  <!-- Topbar Start -->
  <div class="container-fluid d-none d-lg-block">
    <div class="row align-items-center bg-dark px-lg-5">
      <div class="col-lg-9">
        <nav class="navbar navbar-expand-sm bg-dark p-0">
          <ul class="navbar-nav ml-n2">
            <li class="nav-item border-right border-secondary">
              <a class="nav-link text-body small" href="#"
                >Monday, January 1, 2022</a
              >
            </li>
            <li class="nav-item border-right border-secondary">
              <a class="nav-link text-body small" href="#">Advertise</a>
            </li>
            <li class="nav-item border-right border-secondary">
              <router-link class="nav-link text-body small" to="/Contact"
                >Contact</router-link
              >
            </li>
          </ul>
        </nav>
      </div>
      <div class="col-lg-3 text-right d-none d-md-block">
        <nav class="navbar navbar-expand-sm bg-dark p-0">
          <ul class="navbar-nav ml-auto mr-n2">
            <li class="nav-item">
              <a class="nav-link text-body" href="#"
                ><small class="fab fa-twitter"></small
              ></a>
            </li>
            <li class="nav-item">
              <a class="nav-link text-body" href="#"
                ><small class="fab fa-facebook-f"></small
              ></a>
            </li>
            <li class="nav-item">
              <a class="nav-link text-body" href="#"
                ><small class="fab fa-linkedin-in"></small
              ></a>
            </li>
            <li class="nav-item">
              <a class="nav-link text-body" href="#"
                ><small class="fab fa-instagram"></small
              ></a>
            </li>
            <li class="nav-item">
              <a class="nav-link text-body" href="#"
                ><small class="fab fa-google-plus-g"></small
              ></a>
            </li>
            <li class="nav-item">
              <a class="nav-link text-body" href="#"
                ><small class="fab fa-youtube"></small
              ></a>
            </li>
          </ul>
        </nav>
      </div>
    </div>
    <div class="row align-items-center bg-white py-3 px-lg-5">
      <div class="col-lg-4">
        <h1 class="m-0 display-4 text-uppercase text-primary">
          Web<span class="text-secondary font-weight-normal">Tin t???c</span>
        </h1>
      </div>
      <!-- <div class="col-lg-8 text-center text-lg-right">
                <a href="https://htmlcodex.com"><img class="img-fluid" src="../assets/img/ads-728x90.png" alt=""></a>
            </div> -->
    </div>
  </div>
  <!-- Topbar End -->

  <!-- Navbar Start -->
  <div class="container-fluid p-0">
    <nav
      class="navbar navbar-expand-lg bg-dark navbar-dark py-2 py-lg-0 px-lg-5"
    >
      <div
        class="collapse navbar-collapse justify-content-between px-0 px-lg-3"
        id="navbarCollapse"
      >
        <div class="navbar-nav mr-auto py-0">
          <router-link to="/" class="nav-item nav-link">Home</router-link>
          <div class="row" v-for="theloai in theloais" :key="theloai.idTheLoai">
            <router-link
              :to="{ name: 'NewByCategory', params: { id: theloai.idTheLoai } }"
              class="nav-item nav-link"
              >{{ theloai.tenTheLoai }}</router-link
            >
          </div>
        </div>
        <div
          class="input-group ml-auto d-none d-lg-flex"
          style="width: 100%; max-width: 300px"
        >
          <input
            type="text"
            class="form-control border-0"
            placeholder="Keyword"
          />
          <div class="input-group-append">
            <button class="input-group-text bg-primary text-dark border-0 px-3">
              <i class="fa fa-search"></i>
            </button>
          </div>
        </div>
      </div>
    </nav>
  </div>
  <!-- Navbar End -->
</template>
<script>
export default {
  name: "Header",
  data() {
    return {
      theloais: [],
    };
  },
  created() {
    this.gettheloai();
  },
  methods: {
    gettheloai() {
      this.$request
        .get("https://localhost:44309/api/TheLoaiAPI")
        .then((res) => {
          this.theloais = res.data;
        });
    },
  },
};
</script>
<style scoped>
@import url(../../src/assets/css/style.css);
</style>