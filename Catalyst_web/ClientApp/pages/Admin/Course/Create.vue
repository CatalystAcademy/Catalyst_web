<template>
  <div>
    <form @submit.prevent="create" action="/assets/inc/sendemail.php" >
      <input v-model="createData.title" type="text" placeholder="Title" name="title">
      <input v-model="createData.description" type="text" placeholder="Description" name="description">
      <input v-model="createData.startDate" type="date" name="startDate">
      <input v-model="createData.endDate" type="date" name="endDate">
      <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
    </form><!-- /.become-teacher__form-content -->
  </div>

</template>

<script>
  import https from 'https';
  export default {
    name: 'CreateCourse',
    setup() {
      return {
        createData: { title: '', description: '', startDate: '', endDate: '' },
      };
    },
    methods: {
      async create() {
        try {
          await this.$axios.post('/api/Courses/Create', this.createData)
          // Show success message
            .then(function (response) {
              if (response) {
                window.location = "/admin/Course/List"
              }
            })
            .catch(function (error) {
              
            })
        } catch (error) {
          // Handle error and display message
        }
      },
    },
    created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
  }
</script>
