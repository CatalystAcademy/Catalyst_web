<template>
  <div>
    <form @submit.prevent="submitForm" :action="`/api/Blogs/Edit/${blogId}`">
      <input v-model="createData.titleArm" type="text" placeholder="Title in Armenian" name="titleArm">
      <input v-model="createData.titleEng" type="text" placeholder="Title in English" name="titleEng">
      <input v-model="createData.descriptionArm" type="text" placeholder="Description in Armenian" name="descriptionArm">
      <input v-model="createData.descriptionEng" type="text" placeholder="Description in English" name="descriptionEng">
      <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
    </form>
  </div>
</template>

<script>
  import https from 'https';

  export default {
    name: 'EditBlog',
    data() {
      return {
        blogId: null,
        createData: { titleArm: '', titleEng: '', descriptionArm: '', descriptionEng: '' },
      };
    },
    async created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }

      // Check if a course ID is provided in the route parameters
      if (this.$route.params.id) {
        this.blogId = this.$route.params.id;
        await this.fetchCourseDetails();
      }
    },
    methods: {
      async fetchCourseDetails() {
        try {
          const response = await this.$axios.get(`/api/BlogDetails/${this.blogId}`);
          this.createData = { ...response.data };
        } catch (error) {
          console.error('Error fetching course details:', error);
        }
      },
      async submitForm() {
        try {
          const response = await this.$axios.put(`/api/Blog/Edit/${this.blogId}`, this.createData);
          console.log("response", response);
          if (response) {
            this.$toasted.success('Edit successful!');
            // Redirect after a successful edit
            window.location = "/admin/blogs/list";
          }
        } catch (error) {
          // Handle error and display message
          this.$toasted.error('An error occurred. Please try again.');
        }
      },
    },
  };
</script>
