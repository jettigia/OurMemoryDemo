<script>
import axios from 'axios';

class ApiService {
  constructor() {
    this.baseUrl = "https://localhost:44349/api";
  }

  getData(path) {
    let url = `${this.baseUrl}${path}`;
    return axios.get(`${url}`);
  }

  post(path) {
      let url = `${this.baseUrl}${path}`;
      return axios.post(url, path);
  }
}

export default (new ApiService()); // singleton object
</script>