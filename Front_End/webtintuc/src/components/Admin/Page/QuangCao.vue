<template>
<Header />
  <Nav />
  <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
    <div class="row">
      <ol class="breadcrumb">
        <li>
          <a href="#">
            <em class="fa fa-home"></em>
          </a>
        </li>
        <li class="active">Quảng Cáo</li>
      </ol>
    </div>
    <!--/.row-->
    <div class="row">
      <div class="col-lg-12">
        <h1 class="page-header" style="color: white; margin-bottom: 0px">
          Quảng Cáo
        </h1>
      </div>
    </div>
    <!--/.row-->
    <div class="table_scrollbar" style="height: 600px">
      <table
        class="table table-bordered"
        style="width: 2350px; max-width: 3000px; max-height: 200px"
      >
        <thead>
          <tr>
            <th>{{ $t("ID") }}</th>
            <th>{{ $t("Name") }}</th>
            <th>{{ $t("ND") }}</th>
            <th>{{ $t("Tien") }}</th>
            <th>{{ $t("TGBD") }}</th>
            <th>{{ $t("TGKT") }}</th>
            <th style="text-align: center">{{ $t("Anh") }}</th>
            <th>{{ $t("TL") }}</th>
            <th>{{ $t("VT") }}</th>
            <th>{{ $t("CD") }}</th>
            <th>{{ $t("CR") }}</th>
            <th style="text-align: center">{{ $t("DateUpdate") }}</th>
            <th>{{ $t("AccUpdate") }}</th>
            <th>{{ $t("More") }}</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="data in datas" :key="data.idQuangCao">
            <td>{{ data.idQuangCao }}</td>
            <td>{{ data.idnqc }}</td>
            <td>{{ data.noiDungQC }}</td>
            <td>{{ data.tienQC }}</td>
            <td style="text-align: center">{{ format_date(data.tgBatDau) }}</td>
            <td style="text-align: center">
              {{ format_date(data.tgKetThuc) }}
            </td>
            <td>
              <img
                v-bind:src="data.hinhAnh"
                alt=""
                style="width: 200px; height: 100px"
              />
            </td>
            <td>{{ data.thêLoaiQC }}</td>
            <td>{{ data.viTri }}</td>
            <td>{{ data.chieuDai }}</td>
            <td>{{ data.chieuRong }}</td>
            <td style="text-align: center">{{ format_date(data.ngaySua) }}</td>
            <td>{{ data.nguoiSua }}</td>
            <td>
              <button class="button-6">Sửa</button>
              <button class="button-6">Tắt Trạng Thái</button>
              <button class="button-6">Xóa</button>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>
<script>
import axios from "axios";
import moment from "moment";
import Header from "../Layout/Header.vue";
import Nav from "../Layout//Nav.vue";
export default {
  components: {
    Header,
    Nav,
  },
  data() {
    return {
      datas: [],
    };
  },
  
  created: function () {
    this.List();
  },
  methods: {
    List() {
      try {
        axios.get("https://localhost:44309/api/QuangCao").then((response) => {
          this.datas = response.data;
        });
      } catch (error) {
        console.log(error);
      }
    },
    format_date(value) {
      try {
        if (value) {
          return moment(String(value)).format("DD-MM-YYYY");
        }
      } catch (error) {
        console.log(error);
      }
    },
  },
};
</script>