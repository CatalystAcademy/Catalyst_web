<template>
  <div>
    <h2 class="course-list-header">List of Courses</h2>
    <router-link to="/admin/courseCreate" class="btn btn-create">Create Course</router-link>
    <table class="course-table">
      <thead>
        <tr>
          <th>Title</th>
          <th>Description</th>
          <th>Start Date</th>
          <th>End Date</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="course in courses" :key="course.id">
          <td>{{ course.title }}</td>
          <td>{{ course.description }}</td>
          <td>{{ course.startDate }}</td>
          <td>{{ course.endDate }}</td>
          <td>
            <button class="btn btn-edit">Edit</button>
            <button class="btn btn-delete">Delete</button>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>




<script>
  import https from 'https';
  export default {
    name: 'IndexPage',
    async asyncData({ $axios }) { // Inject $axios directly gt
      $axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      try {
        const response = await $axios.get('https://localhost:7226/api/Courses'); // Use relative path
        return { courses: response.data };
      } catch (error) {
        console.error('Error fetching courses:', error);
        return { courses: [] }; // Graceful error handling
      }
    },
  }
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
