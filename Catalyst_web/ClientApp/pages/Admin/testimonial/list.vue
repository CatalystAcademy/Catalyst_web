<template>
  <div>
    <h2 class="course-list-header">List of Testimonials</h2> <router-link to="/admin/Index" class="btn btn-edit">Back to Index</router-link>
    <router-link to="/admin/testimonial/create" class="btn btn-create">Add Testimonial</router-link>
    <table class="course-table">
      <thead>
        <tr>
          <th>Full name in Armenian</th>
          <th>Full name in English</th>
          <th>Position in Armenian</th>
          <th>Position in English</th>
          <th>Text in Armenian</th>
          <th>Text in English</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="testimonial in testimonials" :key="testimonial.id">
          <td>{{ testimonial.fullNameArm }}</td>
          <td>{{ testimonial.fullNameEng }}</td>
          <td>{{ testimonial.positionArm }}</td>
          <td>{{ testimonial.positionEng }}</td>
          <td>{{ testimonial.textArm }}</td>
          <td>{{ testimonial.textEng }}</td>
          <td>
            <router-link :to="`/admin/testimonial/edit/${testimonial.id}`" class="btn btn-edit">Edit</router-link>
            <button class="btn btn-delete" @click="deleteTestimonial(testimonial.id)">Delete</button>
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
      deleteTestimonial(testimonialId) {
        this.$axios.delete(`/api/Testimonial/${testimonialId}`)
          .then(() => {
            // Remove the deleted course from the list
            this.testimonials = this.testimonials.filter(testimonial => testimonial.id !== testimonialId);
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
        const response = await axiosInstance.get('/api/Testimonials');
        return { testimonials: response.data };
      } catch (error) {
        console.error('Error fetching Testimonials:', error);
        return { testimonials: [] }; // Graceful error handling
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
