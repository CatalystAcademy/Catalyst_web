<template>
  <div>
    <h2 class="course-list-header">List of Teachers</h2> <router-link to="/admin/Index" class="btn btn-edit">Back to Index</router-link>
    <router-link to="/admin/teacher/create" class="btn btn-create">Add teacher</router-link>
    <table class="course-table">
      <thead>
        <tr>
          <th>Full name in Armenian</th>
          <th>Full name in English</th>
          <th>Description in Armenian</th>
          <th>Description in English</th>
          <th>Profession in Armenian</th>
          <th>Profession in English</th>
          <th>Leadership</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="teacher in teachers" :key="teacher.id">
          <td>{{ teacher.fullNameArm }}</td>
          <td>{{ teacher.fullNameEng }}</td>
          <td>{{ teacher.professionArm }}</td>
          <td>{{ teacher.professionEng }}</td>
          <td>{{ teacher.descriptionArm }}</td>
          <td>{{ teacher.descriptionEng }}</td>
          <td>{{ teacher.IsFromLeadership }}</td>
          <td>
            <router-link :to="`/admin/teacher/edit/${teacher.id}`" class="btn btn-edit">Edit</router-link>
            <button class="btn btn-delete" @click="deleteTeacher(teacher.id)">Delete</button>
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
      deleteTeacher(teacherId) {
        this.$axios.delete(`/api/Teacher/${teacherId}`)
          .then(() => {
            // Remove the deleted course from the list
            this.teachers = this.teachers.filter(teacher => teacher.id !== teacherId);
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
        const response = await axiosInstance.get('/api/AllInstructors');
        return { teachers: response.data };
      } catch (error) {
        console.error('Error fetching teachers:', error);
        return { teachers: [] }; // Graceful error handling
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
