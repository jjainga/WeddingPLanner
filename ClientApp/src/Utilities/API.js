import axios from "axios";

// Export an object with a "search" 
const API = {
  searchWeddingEvent: function() {return axios.get("/api/Event")},
  searchGuestList: function(url) {return axios.get("/api/Event/guestlist")}
}

export default API;