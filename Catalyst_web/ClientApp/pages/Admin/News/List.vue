<template>
  <div>
    <h2 class="course-list-header">List of News</h2>
    <router-link to="/admin/News/Create" class="btn btn-create">Create News</router-link>
    <table class="course-table">
      <thead>
        <tr>
          <th>Title in Armenian</th>
          <th>Title in English</th>
          <th>Description in Armenian</th>
          <th>Description in English</th>
          <th>Created Date</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="n in news" :key="n.id">
          <td>{{ n.titleArm.slice(0, 50) }}</td>
          <td>{{ n.titleEng.slice(0, 50) }}</td>
          <td>{{ n.descriptionArm.slice(0, 100) }}</td>
          <td>{{ n.descriptionEng.slice(0, 100) }}</td>
          <td>{{ formatDate(n.created) }}</td>
          <td>
            <router-link :to="`/admin/News/edit/${n.id}`" class="btn btn-edit">Edit</router-link>
            <button class="btn btn-delete" @click="deleteNews(n.id)">Delete</button>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>




<script>
  import https from 'https';

  export default {
    name: 'NewsList',
    methods: {
      formatDate(date) {
        // Use this.$moment to format the date
        return this.$moment(date).format('MMMM D, YYYY');
      },
     deleteNews(newsId) {
        this.$axios.delete(`/api/News/${newsId}`)
          .then(() => {
            // Remove the deleted course from the list
            this.news = this.news.filter(n => n.id !== newsId);
            // Display success message (optional)
          })
          .catch(error => {
            // Handle error and display message
            console.error(error);
          });
      },
    },

    async asyncData({ $axios }) {
      const axiosInstance = $axios.create({
        httpsAgent: new https.Agent({ rejectUnauthorized: false }),
      });

      try {
        const response = await axiosInstance.get('/api/News');
        return { news: response.data };
      } catch (error) {
        console.error('Error fetching News:', error);
        return { news: [] }; // Graceful error handling
      }
    },
  };
</script>


<style scoped>
  /* Container styles */
  .course-table {
    width: 100%;
    border-collapse: collapse;
    margin-top: 20px;
  }

    /* Table header styles */
    .course-table th {
      background-color: #f2f2f2;
      padding: 15px;
      text-align: left;
    }

    /* Table data styles */
    .course-table td {
      border: 1px solid #ddd;
      padding: 15px;
    }

  /* Edit and Delete button styles */
  .btn {
    padding: 8px 12px;
    font-size: 1em;
    cursor: pointer;
    border: none;
    border-radius: 4px;
  }

  /* Edit button styles */
  .btn-edit {
    background-color: #4caf50;
    color: white;
  }

  .btn-create {
    background-color: #4caf50;
    color: white;
  }

  /* Delete button styles */
  .btn-delete {
    background-color: #f44336;
    color: white;
  }

  /* Header styles */
  .course-list-header {
    font-size: 2em;
    color: #333;
    margin-bottom: 20px;
  }
</style>
