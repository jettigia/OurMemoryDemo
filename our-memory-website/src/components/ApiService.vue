<script>
import axios from 'axios';

class ApiService {
  constructor() {
    this.baseUrl = "http://localhost:55610/api";
  }

  getData(path) {
    let url = `${this.baseUrl}${path}`;
    return axios.get(`${url}`);
  }

  getUrl(path) {
      return `${this.baseUrl}${path}`;
  }


  post(path, data) {
      let url = `${this.baseUrl}${path}`;
      return axios.post(url, JSON.stringify(data));
  }
}

export default (new ApiService()); // singleton object
</script>