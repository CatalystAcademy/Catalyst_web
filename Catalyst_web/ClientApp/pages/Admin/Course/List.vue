<template>
  <div class="container">
    <h2 class="course-list-header">List of Courses</h2> <router-link to="/admin/Index" class="btn btn-edit">Back to Index</router-link>
    <router-link to="/admin/Course/Create" class="btn btn-create">Create Course</router-link>
    <table class="course-table">
      <thead>
        <tr>
          <th>Title </th>
          <th>Instructor </th>
          <th>Description</th>
          <th>Start Date</th>
          <th>End Date</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="course in courses" :key="course.id">
          <td>{{ course.title }}</td>
          <td>{{ course.instractor }}</td>
          <td>{{ course.description }}</td>
          <td>{{ formatDate(course.startDate) }}</td>
          <td>{{ formatDate(course.endDate) }}</td>
          <td>
            <router-link :to="`/admin/Course/edit/${course.id}`" class="btn btn-edit">Edit</router-link>
            <button class="btn btn-delete" @click="deleteCourse(course.id)">Delete</button>
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
    methods: {
      formatDate(date) {
        // Use this.$moment to format the date
        return this.$moment(date).format('MMMM D, YYYY');
      },
      deleteCourse(courseId) {
        this.$axios.delete(`/api/Courses/${courseId}`)
          .then(() => {
            // Remove the deleted course from the list
            this.courses = this.courses.filter(course => course.id !== courseId);
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
        const response = await axiosInstance.get('/api/Courses');
        return { courses: response.data };
      } catch (error) {
        console.error('Error fetching courses:', error);
        return { courses: [] }; // Graceful error handling
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
